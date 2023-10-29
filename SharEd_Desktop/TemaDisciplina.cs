using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharEd_Desktop
{
    class TemaDisciplina
    {
        private string disciplina, tema;

        public TemaDisciplina(string disciplina, string tema)
        {
            Disciplina = disciplina;
            Tema = tema;
        }

        public TemaDisciplina()
        {

        }

        public bool cadastrarTemaDisciplina()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into TemaDisciplina (nome, disciplina) values ('" + Tema + "','" + Disciplina + "')", DAO_Conexao.con);
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

        public MySqlDataReader consultarTemaDisciplina(string s)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from TemaDisciplina where disciplina = '" + s + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public string Disciplina { get => disciplina; set => disciplina = value; }
        public string Tema { get => tema; set => tema = value; }
    }
}
