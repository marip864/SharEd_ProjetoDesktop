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
                int serie = int.Parse(cbxSerie.Text);   
                Aluno aluno = new Aluno(txtNome.Text, txtRG.Text, txtNascimento.Text, txtTelefone.Text, txtEmail.Text, ra, serie);
                if (aluno.cadastrarAluno())
                    MessageBox.Show("Cadastro realizado com sucesso!");
                else
                    MessageBox.Show("Erro no cadastro!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Preencha todos os campos!");
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
                    MessageBox.Show("Esse aluno já foi cadastrado!");
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
    }
    
}
