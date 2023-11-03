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
    public partial class ExclusaoAluno : Form
    {
        public ExclusaoAluno()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtExcluir.Text != "")
            {
                Aluno aluno = new Aluno();
                aluno.excluirAluno(int.Parse(txtExcluir.Text));
                MessageBox.Show("Excluído com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtExcluir.Text = "";
            }
            else
            {
                MessageBox.Show("Digite um RA para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtExcluir.Text = "";
            }
            txtExcluir.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void txtExcluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (e.KeyChar == 13)
            {
                if (txtExcluir.Text == "")
                {
                    MessageBox.Show("Digite um RA para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(txtExcluir.Text, out n);
                    if (ehUmNumero)
                    {
                        Aluno con_a = new Aluno();

                        MySqlDataReader r = con_a.consultarAlunoRa(int.Parse(txtExcluir.Text));

                        if (r.Read())
                        {
                            dataGridView1.Rows.Add(r["nome"].ToString(), r["classe"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Aluno não cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                        DAO_Conexao.con.Close();
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtExcluir.Text = "";
                    }
                }
            }
        }
    }
}
