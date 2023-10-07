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
    }
}
