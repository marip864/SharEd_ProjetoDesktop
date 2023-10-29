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
    public partial class CadastroDisciplina : Form
    {
        
        public CadastroDisciplina()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string series = "";
            try
            {
                int codigo = int.Parse(txtCodigo.Text);
                Disciplina disc = new Disciplina(cbxArea.Text,txtNome.Text,"",codigo);
                if (checkBox1.Checked)
                {
                    series = (string)series.Concat("1 ");
                }
                if(checkBox2.Checked)
                {
                    series = (string)series.Concat("2 ");
                }
                if (checkBox3.Checked)
                {
                    series = (string)series.Concat("3 ");
                }
                if(checkBox4.Checked)
                {
                    series = (string)series.Concat("4");
                }
                disc.Series = series;
                if (disc.cadastrarDisciplina())
                {
                    MessageBox.Show("Cadastro realizado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNome.Text = "";
                    cbxArea.Text = "";
                    txtCodigo.Text = "";
                    checkBox1.Checked = false;
                    checkBox2.Checked = false;
                    checkBox3.Checked = false;
                    checkBox4.Checked = false;
                }
                else
                    MessageBox.Show("Erro no cadastro!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            


        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Disciplina disc = new Disciplina(int.Parse(txtCodigo.Text));
                bool existe = disc.consultarDisciplina();
                if (!existe)
                {
                    txtNome.Enabled = true;
                    cbxArea.Enabled = true;
                    checkBox1.Enabled = true;
                    checkBox2.Enabled = true;
                    checkBox3.Enabled = true;
                    checkBox4.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Essa disciplina já foi cadastrado!");
                    txtCodigo.Text = "";
                }
            }
        }
    }
}
