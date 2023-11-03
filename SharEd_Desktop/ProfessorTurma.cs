using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharEd_Desktop
{
    class ProfessorTurma
    {
        private int professor_nr;
        private int id_turma;

        public ProfessorTurma(int professor_nr, int id_turma)
        {
            Professor_nr = professor_nr;
            Id_turma = id_turma;
        }

        public ProfessorTurma()
        {

        }

        public bool cadastrarProfessorTurma()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into ProfessorTurma (professor_nr,turma_id) values (" + Professor_nr + "," + Id_turma + ")", DAO_Conexao.con);
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

        public bool excluirProfessorTurma(int nr, int id)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("delete from ProfessorTurma where professor_nr = " + nr + " and turma_id = "+id+"", DAO_Conexao.con);
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

        public bool consultarProfessorTurma(int nr)
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from ProfessorTurma where professor_nr = " + nr + "", DAO_Conexao.con);
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

        public bool consultarProfessorMateriaTurma(int nr)
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from ProfessorTurma where professor_nr = " + nr + "", DAO_Conexao.con);
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

        public MySqlDataReader consultarProfsEmUmaTurma()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select nome, materia from Professor inner join Turma inner join ProfessorTurma on (Professor.numero = ProfessorTurma.professor_nr) and (Turma.idTurma = ProfessorTurma.turma_id) and turma_id = " + Id_turma + "", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public int Professor_nr { get => professor_nr; set => professor_nr = value; }
        public int Id_turma { get => id_turma; set => id_turma = value; }
    }
}
