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
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRA.Text == "")
                {
                    MessageBox.Show("Digite um RA!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int ra = int.Parse(txtRA.Text);
                    Aluno aluno = new Aluno(txtNome.Text, txtRG.Text, txtNascimento.Text, txtTelefone.Text, txtEmail.Text, ra, 0);
                    if ((txtRA.Text == "") || (txtNome.Text == "") || (txtRG.Text == "") || (txtTelefone.Text == "") || (txtEmail.Text == "") || (txtNascimento.Text == ""))
                    {
                        MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        
                        if (aluno.cadastrarAluno())
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNome.Text = "";
                            txtRG.Text = "";
                            txtNascimento.Text = "";
                            txtTelefone.Text = "";
                            txtEmail.Text = "";
                            txtRA.Text = "";
                            txtNome.Enabled = false;
                            txtRG.Enabled = false;
                            txtNascimento.Enabled = false;
                            txtTelefone.Enabled = false;
                            txtEmail.Enabled = false;
                        }
                        else
                            MessageBox.Show("Erro no cadastro!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
        }

        private void txtRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNome.Enabled = false;
                txtRG.Enabled = false;
                txtNascimento.Enabled = false;
                txtTelefone.Enabled = false;
                txtEmail.Enabled = false;
                if (txtRA.Text == "")
                {
                    MessageBox.Show("Digite um RA!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(txtRA.Text, out n);
                    if (ehUmNumero)
                    {
                        Aluno aluno = new Aluno(int.Parse(txtRA.Text));
                        bool existe = aluno.consultarAluno();
                        if (!existe)
                        {
                            txtNome.Enabled = true;
                            txtRG.Enabled = true;
                            txtNascimento.Enabled = true;
                            txtTelefone.Enabled = true;
                            txtEmail.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Esse aluno já foi cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtRA.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtRA.Text = "";
                    }
                }
           
            }

            DAO_Conexao.con.Close();

        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
    
}
