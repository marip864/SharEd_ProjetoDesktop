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
    public partial class AtualizacaoDiretor : Form
    {
        int opcao=0;
        public AtualizacaoDiretor(int op)
        {
            InitializeComponent();
            if (op == 1)
            {
                opcao = 1;
            }
            if (op == 2)
            {
                button1.Visible = false;
                btnAtivo.Visible = false;
                opcao = 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNr.Text == "")
            {
                MessageBox.Show("Digite um NR!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int nr = int.Parse(txtNr.Text);
                Diretor diretor = new Diretor(txtNome.Text, txtRg.Text, txtEmail.Text, txtCargo.Text, txtTelefone.Text, nr);
                if (diretor.atualizarDiretor())
                {
                    MessageBox.Show("Atualização realizada com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void txtNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNome.Text = "";
                txtRg.Text = "";
                txtCargo.Text = "";
                txtTelefone.Text = "";
                txtEmail.Text = "";
                if (txtNr.Text == "")
                {
                    MessageBox.Show("Digite um NR!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n1;
                    bool ehUmNumero = int.TryParse(txtNr.Text, out n1);
                    if (ehUmNumero)
                    {
                        Diretor diretor = new Diretor(int.Parse(txtNr.Text));
                        MySqlDataReader dr = diretor.consultarDiretor01();
                        if (dr.Read())
                        {
                            txtNome.Text = dr["nome"].ToString();
                            txtRg.Text = dr["rg"].ToString();
                            txtCargo.Text = dr["cargo"].ToString();
                            txtTelefone.Text = dr["ramal"].ToString();
                            txtEmail.Text = dr["email"].ToString();
                            txtRg.Enabled = false;
                            if (opcao == 1)
                            {
                                txtNr.Enabled = false;
                                txtNome.Enabled = true;
                                txtRg.Enabled = true;
                                txtCargo.Enabled = true;
                                txtTelefone.Enabled = true;
                                txtEmail.Enabled = true;
                            }

                            DAO_Conexao.con.Close();

                            int n = diretor.verificaAtivo();
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
                            MessageBox.Show("Diretor não cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNr.Text = "";
                        }
                        DAO_Conexao.con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNr.Text = "";
                    }
                }

            }
        }

        private void btnAtivo_Click(object sender, EventArgs e)
        {
            try
            {
                int nr = int.Parse(txtNr.Text);
                Diretor a = new Diretor(nr);
                if (a.tornarAtivo())
                {
                    MessageBox.Show("Diretor ativado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
