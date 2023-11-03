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
            try
            {
                if (txtCodigo.Text == "")
                {
                    MessageBox.Show("Digite um código!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int codigo = int.Parse(txtCodigo.Text);
                    Disciplina disc = new Disciplina(cbxArea.Text, txtNome.Text, codigo);
                    if (disc.cadastrarDisciplina())
                    {
                        MessageBox.Show("Cadastro realizado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNome.Text = "";
                        cbxArea.Text = "";
                        txtCodigo.Text = "";
                        txtNome.Enabled = false;
                        cbxArea.Enabled = false;
                    }
                    else
                        MessageBox.Show("Erro no cadastro!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Digite um código!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }          

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtNome.Enabled = false;
                cbxArea.Enabled = false;
                if (txtCodigo.Text == "")
                {
                    MessageBox.Show("Digite um código!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(txtCodigo.Text, out n);
                    if (ehUmNumero)
                    {
                        Disciplina disc = new Disciplina(int.Parse(txtCodigo.Text));
                        bool existe = disc.consultarDisciplina();
                        if (!existe)
                        {
                            txtNome.Enabled = true;
                            cbxArea.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Essa disciplina já foi cadastrada!");
                            txtCodigo.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Text = "";
                    }
                }
            }
        }
    }
}
