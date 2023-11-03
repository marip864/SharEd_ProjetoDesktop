using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SharEd_Desktop
{
    class AlunoTurma
    {
        private int aluno_ra;

        public AlunoTurma(int aluno_ra)
        {
            Aluno_ra = aluno_ra;
        }

        private int id_turma;

        public AlunoTurma()
        {

        }

        public bool cadastrarAlunoTurma(int serie)
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into AlunoTurma (aluno_ra,turma_id) values (" + Aluno_ra + "," + Id_turma + ")", DAO_Conexao.con);
                insere.ExecuteNonQuery();
                MySqlCommand insere2 = new MySqlCommand("update Aluno set classe = " + serie + " where ra = "+Aluno_ra+"", DAO_Conexao.con);
                insere2.ExecuteNonQuery();
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



        public int selecionaSerie()
        {
            MySqlDataReader resultS = null;
            int resultI = 0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select serie from Turma where idTurma = " + Id_turma + "", DAO_Conexao.con);
                resultS = consulta.ExecuteReader();
                if (resultS.Read())
                {
                    resultI = int.Parse(resultS["serie"].ToString());
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
            return resultI;
        }

        public MySqlDataReader consultarAlunosEmUmaTurma()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select nome from Aluno inner join Turma inner join AlunoTurma on (Aluno.ra = AlunoTurma.aluno_ra) and (Turma.idTurma = AlunoTurma.turma_id) and turma_id = " + Id_turma + "", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public bool consultarAlunoTurma(int ra)
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from AlunoTurma where aluno_ra = " + ra + "", DAO_Conexao.con);
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

        public bool excluirAlunoTurma(int ra)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("delete from AlunoTurma where aluno_ra = " + ra + "", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                MySqlCommand exclui2 = new MySqlCommand("update Aluno set classe = 0 where ra = " + ra + "", DAO_Conexao.con);
                exclui2.ExecuteNonQuery();
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

        public AlunoTurma(int aluno_ra, int id_turma)
        {
            Aluno_ra = aluno_ra;
            Id_turma = id_turma;
        }

        public int Aluno_ra { get => aluno_ra; set => aluno_ra = value; }
        public int Id_turma { get => id_turma; set => id_turma = value; }
    }
}
