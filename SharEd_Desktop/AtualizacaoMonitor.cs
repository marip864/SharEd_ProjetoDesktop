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
    public partial class AtualizacaoMonitor : Form
    {
        int opcao = 0;
        public AtualizacaoMonitor(int op)
        {
            InitializeComponent();
            if (op == 1)
            {
                opcao = 1;
            }
            if (op == 2)
            {
                btnAtualizar.Visible = false;
                btnAtivo.Visible = false;
                opcao = 2;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtRa.Text == "")
            {
                MessageBox.Show("Digite um RA!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int ra = int.Parse(txtRa.Text);
                int serie = int.Parse(txtSerie.Text);
                Monitor monitor = new Monitor(txtNome.Text, txtRg.Text, txtNascimento.Text, txtTelefone.Text, txtEmail.Text, txtDisciplina.Text, ra, serie);
                if (monitor.atualizarMonitor())
                {
                    MessageBox.Show("Atualização realizada com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtRa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                txtNome.Text = "";
                txtRg.Text = "";
                txtSerie.Text = "";
                txtNascimento.Text  = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                txtDisciplina.Text = "";
                if (txtRa.Text == "")
                {
                    MessageBox.Show("Digite um RA!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n1;
                    bool ehUmNumero = int.TryParse(txtRa.Text, out n1);
                    if (ehUmNumero)
                    {
                        Monitor monitor = new Monitor(int.Parse(txtRa.Text));
                        MySqlDataReader dr = monitor.consultarMonitor01();
                        if (dr.Read())
                        {
                            txtNome.Text = dr["nome"].ToString();
                            txtRg.Text = dr["rg"].ToString();
                            txtSerie.Text = dr["classe"].ToString();
                            txtNascimento.Text = dr["dataNascimento"].ToString();
                            txtTelefone.Text = dr["celular"].ToString();
                            txtEmail.Text = dr["emailInstitucional"].ToString();
                            txtDisciplina.Text = dr["area"].ToString();
                            txtRg.Enabled = false;
                            if (opcao == 1)
                            {
                                txtRa.Enabled = false;
                                txtNome.Enabled = true;
                                txtRg.Enabled = true;
                                txtSerie.Enabled = true;
                                txtNascimento.Enabled = true;
                                txtTelefone.Enabled = true;
                                txtEmail.Enabled = true;
                                txtDisciplina.Enabled = true;
                            }

                            DAO_Conexao.con.Close();

                            int n = monitor.verificaAtivo();
                            if (n == 1)
                            {
                                btnAtivo.Enabled = true;
                            }
                            else
                            {
                                btnAtivo.Enabled = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Monitor não cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtRa.Text = "";
                        }
                        DAO_Conexao.con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtRa.Text = "";
                    }
                }

            }
        }

        private void btnAtivo_Click(object sender, EventArgs e)
        {
            try
            {
                int ra = int.Parse(txtRa.Text);
                Monitor a = new Monitor(ra);
                if (a.tornarAtivo())
                {
                    MessageBox.Show("Monitor ativado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione uma opção para atualizar!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            DAO_Conexao.con.Close();
        }
    }
}
