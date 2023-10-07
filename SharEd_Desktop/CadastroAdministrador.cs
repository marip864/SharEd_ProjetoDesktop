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
                }
                    
                else
                    MessageBox.Show("Erro no cadastro!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

    }
}
