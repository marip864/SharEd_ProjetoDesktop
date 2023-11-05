using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SharEd_Desktop
{
    class Turma
    {
        private string curso, periodo, nome;

        public Turma(string curso)
        {
            Curso = curso;
        }

        private int serie;

        public Turma(string curso, int serie, string periodo, string nome)
        {
            Curso = curso;
            Serie = serie;
            Periodo = periodo;
            Nome = nome;
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
                MySqlCommand insere = new MySqlCommand("insert into Turma (curso,serie, periodo, nomeTurma) values ('" + Curso + "'," + Serie + ",'"+Periodo+"', '"+Nome+"')", DAO_Conexao.con);
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


        public int selecionaIdTurma(string nome)
        {
            MySqlDataReader resultS = null;
            int resultI = 0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select idTurma from Turma where nomeTurma = '" + nome + "'", DAO_Conexao.con);
                resultS = consulta.ExecuteReader();
                if (resultS.Read())
                {
                    resultI = int.Parse(resultS["idTurma"].ToString());
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


        public int selecionaIdTurmadoAluno(int ra)
        {
            MySqlDataReader resultS = null;
            int resultI = 0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select turma_id from AlunoTurma where aluno_ra = " + ra + "", DAO_Conexao.con);
                resultS = consulta.ExecuteReader();
                if (resultS.Read())
                {
                    resultI = int.Parse(resultS["turma_id"].ToString());
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

        public int selecionaIdTurmadoProfessor(int nr)
        {
            MySqlDataReader resultS = null;
            int resultI = 0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select turma_id from ProfessorTurma where professor_nr = " + nr + "", DAO_Conexao.con);
                resultS = consulta.ExecuteReader();
                if (resultS.Read())
                {
                    resultI = int.Parse(resultS["turma_id"].ToString());
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

        public MySqlDataReader consultarTurmaCurso()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Turma where curso = '"+Curso+"' and ativa = 0", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public MySqlDataReader consultarTurmasDesativadas()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Turma where ativa = 1", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public bool tornarAtivo(string turma)
        {
            bool result = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Turma set ativa = 0 where nomeTurma = '" + turma + "'", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
        }


        public MySqlDataReader consultarTurmaNome()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Turma where ativa = 0", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public MySqlDataReader consultaNomedaTurma(int id)
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select nomeTurma from Turma where idTurma = "+id+"", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public MySqlDataReader consultaNomedaTurmaProfessor()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select nomeTurma,idTurma from Turma inner join Professor inner join ProfessorTurma on (Professor.numero = ProfessorTurma.professor_nr) and (Turma.idTurma = ProfessorTurma.turma_id)", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public MySqlDataReader consultarTurmasPeloNome()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select nomeTurma from Turma where ativa = 0", DAO_Conexao.con);
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

        public bool excluirTurma(string nomeTurma, int id_turma)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Turma set ativa = 1 where nomeTurma ='" + nomeTurma + "'", DAO_Conexao.con);
                exclui.ExecuteNonQuery();
                MySqlCommand exclui2 = new MySqlCommand("delete from AlunoTurma where turma_id = " + id_turma + "", DAO_Conexao.con);
                exclui2.ExecuteNonQuery();
                MySqlCommand exclui3 = new MySqlCommand("delete from ProfessorTurma where turma_id = "+id_turma+"", DAO_Conexao.con);
                exclui3.ExecuteNonQuery();
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

        public bool existeTurma(string curso, int serie, string periodo)
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("select * from Turma where ativo = 0 and curso ='" + curso + "' and serie = " + serie + " and periodo = '" + periodo + "'", DAO_Conexao.con);
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
        public string Nome { get => nome; set => nome = value; }
    }
}
