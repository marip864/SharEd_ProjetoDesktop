using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharEd_Desktop
{
    public partial class CadastroMonitor : Form
    {
        public CadastroMonitor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ra = int.Parse(txtRa.Text);
                Monitor monitor = new Monitor(txtNome.Text, txtRg.Text, txtNascimento.Text, txtTelefone.Text, txtEmail.Text, cbxDisciplina.Text, ra, cbxSerie.Text);
                if (monitor.cadastrarMonitor())
                    MessageBox.Show("Cadastro realizado com sucesso!");
                else
                    MessageBox.Show("Erro no cadastro!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void txtRa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Monitor monitor = new Monitor(int.Parse(txtRa.Text));
                bool existeAluno = monitor.consultarAlunoparaMonitor(int.Parse(txtRa.Text));
                bool existeMonitor = monitor.consultarMonitor();
                if (existeAluno)
                {
                    if (!existeMonitor)
                    {
                        Aluno aluno = new Aluno(int.Parse(txtRa.Text));
                        MySqlDataReader dr = aluno.consultarAluno02();
                        if (dr.Read())
                        {
                            txtNome.Text = dr["nome"].ToString();
                            txtRg.Text = dr["rg"].ToString();
                            cbxSerie.Text = dr["classe"].ToString();
                            txtNascimento.Text = dr["dataNascimento"].ToString();
                            txtTelefone.Text = dr["celular"].ToString();
                            txtEmail.Text = dr["emailInstitucional"].ToString();
                            cbxDisciplina.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Esse monitor já foi cadastrado!");
                        txtRa.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("É necessário que o aluno já esteja cadastrado!");
                }
                }
                
                DAO_Conexao.con.Close();
                /*int n = aluno.verificaAtivo();
                if (n == 1)
                {
                    button2.Enabled = true;
                }
                else
                {
                    button2.Enabled = false;
                }*/

            }
        }
    }

