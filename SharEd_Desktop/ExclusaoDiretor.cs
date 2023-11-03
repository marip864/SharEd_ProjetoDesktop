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
    public partial class ExclusaoDiretor : Form
    {
        public ExclusaoDiretor()
        {
            InitializeComponent();
        }

        private void txtExcluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (e.KeyChar == 13)
            {
                if (txtExcluir.Text == "")
                {
                    MessageBox.Show("Digite um NR para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(txtExcluir.Text, out n);
                    if (ehUmNumero)
                    {
                        Diretor con_d = new Diretor();

                        MySqlDataReader r = con_d.consultarDiretorNr(int.Parse(txtExcluir.Text));

                        if (r.Read())
                        {
                            dataGridView1.Rows.Add(r["nome"].ToString(), r["cargo"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Diretor não cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtExcluir.Text = "";
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

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtExcluir.Text != "")
            {
                Diretor diretor = new Diretor();
                diretor.excluirDiretor(int.Parse(txtExcluir.Text));
                MessageBox.Show("Excluído com sucesso! ", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Digite um NR para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtExcluir.Text = "";
            dataGridView1.Rows.Clear();
        }
    }
}
