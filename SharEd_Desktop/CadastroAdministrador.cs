using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SharEd_Desktop
{
    public partial class CadastroAdministrador : Form
    {
        public CadastroAdministrador()
        {
            InitializeComponent();
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNr.Text == "")
                {
                    MessageBox.Show("Digite um NR!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int nr = int.Parse(txtNr.Text);
                    Administrador admin = new Administrador(txtNome.Text, txtRg.Text, cbxCargo.Text, txtTelefone.Text, txtEmail.Text, nr);
                    if ((txtNr.Text == "") || (cbxCargo.Text == "") || (txtNome.Text == "") || (txtRg.Text == "") || (txtTelefone.Text == "") || (txtEmail.Text == "") || (txtSenha.Text == ""))
                    {
                        MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (admin.cadastrarAdministrador())
                        {
                            int tipo = 1;
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
                            txtSenha.Enabled = false;
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

        private void txtNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                txtNome.Enabled = false;
                txtRg.Enabled = false;
                cbxCargo.Enabled = false;
                txtTelefone.Enabled = false;
                txtEmail.Enabled = false;
                txtRg.Enabled = false;
                txtSenha.Enabled = false;
                if (txtNr.Text == "")
                {
                    MessageBox.Show("Digite um NR!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(txtNr.Text, out n);
                    if (ehUmNumero)
                    {
                        Administrador admin = new Administrador(int.Parse(txtNr.Text));
                        bool existe = admin.consultarAdministrador();
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
                            MessageBox.Show("Esse administrador já foi cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNr.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNr.Text = "";
                    }
                }
            }
        }
    }
}
