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
    public partial class AtualizacaoProfessor : Form
    {
        int opcao = 0;
        public AtualizacaoProfessor(int op)
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

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (txtNr.Text == "")
            {
                MessageBox.Show("Digite um NR!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                int nr = int.Parse(txtNr.Text);
                Professor prof = new Professor(txtNome.Text, txtRg.Text, txtMaterias.Text, txtTelefone.Text, txtEmail.Text, nr);
                if (prof.atualizarProfessor())
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
                txtMaterias.Text = "";
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
                        Professor professor = new Professor(int.Parse(txtNr.Text));
                        MySqlDataReader dr = professor.consultaProfessor02();
                        if (dr.Read())
                        {
                            txtNome.Text = dr["nome"].ToString();
                            txtRg.Text = dr["rg"].ToString();
                            txtMaterias.Text = dr["materia"].ToString();
                            txtTelefone.Text = dr["telefone"].ToString();
                            txtEmail.Text = dr["email"].ToString();
                            txtRg.Enabled = false;
                            if (opcao == 1)
                            {
                                txtNr.Enabled = false;
                                txtNome.Enabled = true;
                                txtRg.Enabled = true;
                                txtMaterias.Enabled = true;
                                txtTelefone.Enabled = true;
                                txtEmail.Enabled = true;
                            }
                            int n = professor.verificaAtivo();
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
                            MessageBox.Show("Professor não cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                Professor a = new Professor(nr);
                if (a.tornarAtivo())
                {
                    MessageBox.Show("Professor ativado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
