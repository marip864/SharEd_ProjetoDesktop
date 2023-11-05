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
    public partial class CadastroTema : Form
    {
        public CadastroTema()
        {
            InitializeComponent();
            Disciplina con_disc = new Disciplina();
            MySqlDataReader r = con_disc.consultarTodasDisciplinas();
            while (r.Read())
                dataGridView1.Rows.Add(r["nomeDisciplina"].ToString());
            DAO_Conexao.con.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDisciplina.Text == "")
                {
                    MessageBox.Show("Selecione uma disciplina!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if(txtTema.Text=="")
                {
                    MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    TemaDisciplina tema = new TemaDisciplina(txtDisciplina.Text, txtTema.Text);
                    if (!tema.consultarTemaDisciplina())
                    {
                        MessageBox.Show(tema.consultarTemaDisciplina().ToString());
                        MessageBox.Show("O tema já foi cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (tema.cadastrarTemaDisciplina())
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtDisciplina.Text = "";
                            txtTema.Text = "";
                            txtTema.Enabled = false;
                        }
                        else
                            MessageBox.Show("Erro no cadastro!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDisciplina.Text = dataGridView1.CurrentCell.Value.ToString();
            txtTema.Enabled = true;
        }
    }
}
