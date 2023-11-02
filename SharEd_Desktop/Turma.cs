using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SharEd_Desktop
{
    class Turma
    {
        private string curso, periodo;

        public Turma(string curso)
        {
            Curso = curso;
        }

        private int serie;

        public Turma(string curso, int serie, string periodo)
        {
            Curso = curso;
            Serie = serie;
            Periodo = periodo;
        }

        public Turma()
        {

        }

        public bool cadastrarTurma()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Turma (curso,serie, periodo) values ('" + Curso + "'," + Serie + ",'"+Periodo+"')", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                cad = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return cad;
        }

        public bool consultarTurma()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Turma where serie ='" + Serie + "' and curso = '"+Curso+"' and periodo = '"+Periodo+"'", DAO_Conexao.con);
                MySqlDataReader resultado = consulta.ExecuteReader();
                if (resultado.Read())
                {
                    existe = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return existe;
        }

        public MySqlDataReader consultarTurmaCurso()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Turma where curso = '"+Curso+"'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }


        public MySqlDataReader consultarIDTurma(string curso, int serie, string periodo)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select idTurma from Turma where curso ='"+curso+"' and serie = "+serie+" and periodo = '"+periodo+"'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public bool excluirTurma(string curso, int serie, string periodo)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Turma set ativo = 1 where curso ='" + curso + "' and serie = " + serie + " and periodo = '" + periodo + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                exc = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            finally
            {
                DAO_Conexao.con.Close();
            }
            return exc;
        }


        public string Curso { get => curso; set => curso = value; }
        public int Serie { get => serie; set => serie = value; }
        public string Periodo { get => periodo; set => periodo = value; }
    }
}
