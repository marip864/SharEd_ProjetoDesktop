using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace SharEd_Desktop
{
    class Disciplina
    {
        private string area, nome, series;
        private int codigo;

        public Disciplina(int codigo)
        {
            Codigo = codigo;
        }

        public Disciplina(string area, string nome, string series, int codigo)
        {
            Area1 = area;
            Nome = nome;
            Series = series;
            Codigo = codigo;
        }
        public bool cadastrarDisciplina()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Disciplina (codigo,nomeDisciplina,area,series) values (" + Codigo + ",'" + Nome + "','" + Area1 + "','" + Series + "')", DAO_Conexao.con);
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

        public bool atualizarDisciplina()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Disciplina set nomeDisciplina='" + Nome + "', area='" + Area1 + "', series='" + Series + "' where codigo =" + Codigo + "", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
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
        public bool consultarDisciplina()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Disciplina where codigo =" + Codigo + "", DAO_Conexao.con);
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

        public bool tornarAtivo()
        {
            bool result = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Disciplina set ativa = 0 where codigo = " + Codigo + "", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
        }

        public bool excluirDiretor(int codigo)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update MembroDirecao set ativa = 1 where codigo = " + codigo + "", DAO_Conexao.con);
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


        public string Nome { get => nome; set => nome = value; }
        public string Series { get => series; set => series = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public string Area1 { get => area; set => area = value; }
    }
}
