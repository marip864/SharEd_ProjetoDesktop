using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharEd_Desktop
{
    class Monitor
    {
        private String nome, rg, nascimento, telefone, email, area, serie;

        public Monitor(string rg)
        {
            Rg = rg;
        }

        public Monitor(string nome, string rg, string nascimento, string telefone, string email, string area, int ra, string serie) 
        {
            Rg = rg;
            Nascimento = nascimento;
            Telefone = telefone;
            Email = email;
            Area = area;
            Ra = ra;
            Serie = serie;
        }

        private int ra;

        public Monitor(int ra)
        {
            Ra = ra;
        }

        public bool cadastrarMonitor()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand insere = new MySqlCommand("insert into Monitor (ra,nome,celular,rg,emailInstitucional,dataNascimento,classe,area) values (" + Ra + ",'" + Nome + "','" + Telefone + "','" + Rg + "','" + Email + "','" + Nascimento + "','" + Serie + "','" + Area + "')", DAO_Conexao.con);
                MessageBox.Show("PAssou Aqui");
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

        public bool atualizarMonitor()
        {
            bool cad = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Monitor set nome='" + Nome + "', celular='" + Telefone + "', rg='" + Rg + "', emailInstitucional='" + Email + "', dataNascimento='" + Nascimento + "', classe='" + Serie + "' where ra ="+Ra+"", DAO_Conexao.con);
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
        public bool consultarMonitor()
        {
            bool existe = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Monitor where ra ='" + Ra + "'", DAO_Conexao.con);
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

        public MySqlDataReader consultarMonitor01()
        {
            MySqlDataReader resultado = null;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select * from Monitor where rg ='" + Rg + "'", DAO_Conexao.con);
                resultado = consulta.ExecuteReader();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return resultado;
        }

        public int verificaAtivo()
        {
            MySqlDataReader resultS = null;
            int resultI = 0;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand consulta = new MySqlCommand("select ativo from Monitor where ra = '" + Ra + "'", DAO_Conexao.con);
                resultS = consulta.ExecuteReader();
                if (resultS.Read())
                {
                    resultI = int.Parse(resultS["ativo"].ToString());
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

        public bool tornarAtivo()
        {
            bool result = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand atualiza = new MySqlCommand("update Monitor set ativo = 0 where ra = '" + Ra + "'", DAO_Conexao.con);
                atualiza.ExecuteNonQuery();
                result = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
        }

        public bool excluirMonitor()
        {
            bool exc = false;
            try
            {
                DAO_Conexao.con.Open();
                MySqlCommand exclui = new MySqlCommand("update Monitor set ativo = 1 where ra = '" + Ra + "'", DAO_Conexao.con);
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
        public string Rg { get => rg; set => rg = value; }
        public string Nascimento { get => nascimento; set => nascimento = value; }
        public string Telefone { get => telefone; set => telefone = value; }
        public string Email { get => email; set => email = value; }
        public int Ra { get => ra; set => ra = value; }
        public string Serie { get => serie; set => serie = value; }
        public string Area { get => area; set => area = value; }
    }

    }
