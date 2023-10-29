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
                int ra = int.Parse(txtRA.Text);
                Aluno aluno = new Aluno(txtNome.Text, txtRG.Text, txtNascimento.Text, txtTelefone.Text, txtEmail.Text, ra, 0);
                if ((txtRA.Text == "") || (cbxSerie.Text == "") || (txtNome.Text == "") || (txtRG.Text == "") || (txtTelefone.Text == "") || (txtEmail.Text == "") || (txtNascimento.Text == ""))
                {
                    MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (cbxSerie.SelectedIndex == 0)
                    {
                        aluno.Serie = 1;
                    }
                    else if (cbxSerie.SelectedIndex == 1)
                    {
                        aluno.Serie = 2;
                    }
                    else if (cbxSerie.SelectedIndex == 2)
                    {
                        aluno.Serie = 3;
                    }
                    else
                    {
                        aluno.Serie = 4;
                    }
                    if (aluno.cadastrarAluno())
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNome.Text = "";
                        txtRG.Text = "";
                        cbxSerie.Text = "";
                        txtNascimento.Text = "";
                        txtTelefone.Text = "";
                        txtEmail.Text = "";
                        txtRA.Text = "";
                        txtNome.Enabled = false;
                        txtRG.Enabled = false;
                        cbxSerie.Enabled = false;
                        txtNascimento.Enabled = false;
                        txtTelefone.Enabled = false;
                        txtEmail.Enabled = false;
                    }
                    else
                        MessageBox.Show("Erro no cadastro!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                Aluno aluno = new Aluno(int.Parse(txtRA.Text));
                bool existe = aluno.consultarAluno();
                if (!existe)
                {
                    txtNome.Enabled = true;
                    txtRG.Enabled = true;
                    cbxSerie.Enabled = true;
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

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
    
}
