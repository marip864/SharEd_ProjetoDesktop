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
                if (diretor.cadastrarDiretor())
                {
                    int tipo = 2;
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
