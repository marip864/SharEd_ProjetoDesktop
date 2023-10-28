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
                int nr = int.Parse(txtNr.Text);
                Administrador admin = new Administrador(txtNome.Text, txtRg.Text, cbxCargo.Text, txtTelefone.Text, txtEmail.Text, nr);
                if (admin.cadastrarAdministrador())
                {
                    int tipo = 1;
                    DAO_Conexao.CadLogin(txtNome.Text, txtSenha.Text, tipo);
                    MessageBox.Show("Cadastro realizado com sucesso!");
                    txtNome.Text = "";
                    txtRg.Text = "";
                    cbxCargo.Text = "";
                    txtTelefone.Text = "";
                    txtEmail.Text = "";
                    txtRg.Text = "";
                    txtNr.Text = "";
                    txtSenha.Text = "";
                }
                    
                else
                    MessageBox.Show("Erro no cadastro!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void txtNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
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
                    MessageBox.Show("Esse administrador já foi cadastrado!");
                    txtNr.Text = "";
                }
            }
        }
    }
}
