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
                if (txtNr.Text == "")
                {
                    MessageBox.Show("Digite um NR!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int nr = int.Parse(txtNr.Text);
                    Professor prof = new Professor(txtNome.Text, txtRg.Text, cbxMateria.Text, txtTelefone.Text, txtEmail.Text, nr);
                    if ((txtNr.Text == "") || (cbxMateria.Text == "") || (txtNome.Text == "") || (txtRg.Text == "") || (txtTelefone.Text == "") || (txtEmail.Text == "") )
                    {
                        MessageBox.Show("Preencha todos os campos!");
                    }
                    else
                    {
                        if (prof.cadastrarProfessor())
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!");
                            txtNome.Text = "";
                            txtRg.Text = "";
                            txtTelefone.Text = "";
                            txtEmail.Text = "";
                            txtRg.Text = "";
                            txtNr.Text = "";
                            cbxMateria.Text = "";
                            txtNome.Enabled = false;
                            txtRg.Enabled = false;
                            txtTelefone.Enabled = false;
                            txtEmail.Enabled = false;
                            txtRg.Enabled = false;
                            cbxMateria.Enabled = false;
                        }
                        else
                            MessageBox.Show("Erro no cadastro!");
                    }
                }
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
                txtNome.Enabled = false;
                txtRg.Enabled = false;
                txtTelefone.Enabled = false;
                txtEmail.Enabled = false;
                txtRg.Enabled = false;
                cbxMateria.Enabled = false;
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
                            Disciplina con_d = new Disciplina();

                            MySqlDataReader r = con_d.consultarDisciplinasPeloNome();

                            while (r.Read())
                            {
                                cbxMateria.Items.Add(r["nomeDisciplina"].ToString());
                            }

                            DAO_Conexao.con.Close();
                        }
                        else
                        {
                            MessageBox.Show("Esse diretor já foi cadastrado!");
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
