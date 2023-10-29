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
    public partial class CadastroDiretor : Form
    {
        public CadastroDiretor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int ra = int.Parse(txtNr.Text);
                Diretor diretor = new Diretor(txtNome.Text, txtRg.Text, txtEmail.Text, cbxCargo.Text, txtTelefone.Text, ra);
                if ((txtNr.Text == "") || (cbxCargo.Text == "") || (txtNome.Text == "") || (txtRg.Text == "") || (txtTelefone.Text == "") || (txtEmail.Text == "") || (txtSenha.Text == ""))
                {
                    MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (diretor.cadastrarDiretor())
                    {
                        int tipo = 2;
                        DAO_Conexao.CadLogin(txtNome.Text, txtSenha.Text, tipo);
                        MessageBox.Show("Cadastro realizado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNome.Text = "";
                        txtRg.Text = "";
                        cbxCargo.Text = "";
                        txtTelefone.Text = "";
                        txtEmail.Text = "";
                        txtRg.Text = "";
                        txtNr.Text = "";
                        txtSenha.Text = "";
                        txtNome.Enabled = false;
                        txtRg.Enabled = false;
                        cbxCargo.Enabled = false;
                        txtTelefone.Enabled = false;
                        txtEmail.Enabled = false;
                        txtRg.Enabled = false;
                        txtSenha.Enabled = false;
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

        private void txtNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Diretor diretor = new Diretor(int.Parse(txtNr.Text));
                bool existe = diretor.consultarDiretor();
                if (!existe)
                {
                    txtNome.Enabled = true;
                    txtRg.Enabled = true;
                    cbxCargo.Enabled = true;
                    txtTelefone.Enabled = true;
                    txtEmail.Enabled = true;
                    txtRg.Enabled = true;
                    txtNr.Enabled = true;
                    txtSenha.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Esse diretor já foi cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNr.Text = "";
                }
            }
        
        }
    }
}
