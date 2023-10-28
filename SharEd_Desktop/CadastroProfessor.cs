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
    public partial class CadastroProfessor : Form
    {
        public CadastroProfessor()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int nr = int.Parse(txtNr.Text);
                Professor prof = new Professor(txtNome.Text, txtRg.Text, cbxSeries.Text, cbxMateria.Text, txtTelefone.Text, txtEmail.Text, nr);
                if (prof.cadastrarProfessor())
                    MessageBox.Show("Cadastro realizado com sucesso!");
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
            if (e.KeyChar == 13)
            {
                Professor prof = new Professor(int.Parse(txtNr.Text));
                bool existe = prof.consultarProfessor();
                if (!existe)
                {
                    txtNome.Enabled = true;
                    txtRg.Enabled = true;
                    txtTelefone.Enabled = true;
                    txtEmail.Enabled = true;
                    txtRg.Enabled = true;
                    txtNr.Enabled = true;
                    cbxMateria.Enabled = true;
                    cbxSeries.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Esse diretor já foi cadastrado!");
                    txtNr.Text = "";
                }
            }
        }
    }
}
