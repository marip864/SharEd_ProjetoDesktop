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
                if (txtRa.Text == "")
                {
                    MessageBox.Show("Digite um RA!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int ra = int.Parse(txtRa.Text);
                    Monitor monitor = new Monitor(txtNome.Text, txtRg.Text, txtNascimento.Text, txtTelefone.Text, txtEmail.Text, cbxDisciplina.Text, ra, 0);
                    if ((txtRa.Text == "") || (cbxSerie.Text == "") || (txtNome.Text == "") || (txtRg.Text == "") || (txtTelefone.Text == "") || (txtEmail.Text == "") || (txtNascimento.Text == "") || (cbxDisciplina.Text == ""))
                    {
                        MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        
                        if (cbxSerie.Text.Equals("2° ano"))
                        {
                            monitor.Serie = 2;
                        }
                        else if (cbxSerie.Text.Equals("3° ano"))
                        {
                            monitor.Serie = 3;
                        }
                        else
                        {
                            monitor.Serie = 4;
                        }
                        if (monitor.cadastrarMonitor())
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNome.Text = "";
                            txtRg.Text = "";
                            cbxSerie.Text = "";
                            txtNascimento.Text = "";
                            txtTelefone.Text = "";
                            txtEmail.Text = "";
                            cbxDisciplina.Text = "";
                            txtRa.Text = "";
                            txtNome.Enabled = false;
                            txtRg.Enabled = false;
                            cbxSerie.Enabled = false;
                            txtNascimento.Enabled = false;
                            txtTelefone.Enabled = false;
                            txtEmail.Enabled = false;
                            cbxDisciplina.Enabled = false;
                        }
                        else
                            MessageBox.Show("Erro no cadastro!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtRa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtRa.Text == "")
                {
                    MessageBox.Show("Digite um RA!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(txtRa.Text, out n);
                    if (ehUmNumero)
                    {
                        Aluno a = new Aluno(int.Parse(txtRa.Text));
                        if (a.consultarAluno())
                        {
                            Monitor monitor = new Monitor(int.Parse(txtRa.Text));
                            bool existeAluno = monitor.consultarAlunoparaMonitor(int.Parse(txtRa.Text));
                            bool existeMonitor = monitor.consultarMonitor();
                            if (!monitor.consultarAlunoTurmaparaMonitor(int.Parse(txtRa.Text)))
                            {
                                MessageBox.Show("É necessário que o aluno esteja vinculado a uma turma!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtRa.Text = "";
                            }
                            else
                            {
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
                                            cbxSerie.Text = string.Concat(dr["classe"].ToString() + "° ano");
                                            txtNascimento.Text = dr["dataNascimento"].ToString();
                                            txtTelefone.Text = dr["celular"].ToString();
                                            txtEmail.Text = dr["emailInstitucional"].ToString();
                                            cbxDisciplina.Enabled = true;
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Esse monitor já foi cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                        txtRa.Text = "";
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("É necessário que o aluno esteja cadastrado nas séries adequadas!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    txtRa.Text = "";
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show("É necessário que o aluno esteja cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtRa.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtRa.Text = "";
                    }
                }

                DAO_Conexao.con.Close();

            }
        }
        }
    }

