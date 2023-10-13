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
    public partial class ExclusaoProfessor : Form
    {
        public ExclusaoProfessor()
        {
            InitializeComponent();
        }

        private void txtExcluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (e.KeyChar == 13)
            {
                Professor con_p = new Professor();

                MySqlDataReader r = con_p.consultarProfessor(int.Parse(txtExcluir.Text));

                if (r.Read())
                {
                    dataGridView1.Rows.Add(r["nome"].ToString(), r["materia"].ToString());
                }
                else
                {
                    MessageBox.Show("Professor não cadastrado!");
                }

                DAO_Conexao.con.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtExcluir.Text != "")
            {
                Professor prof = new Professor();
                prof.excluirProfessor(int.Parse(txtExcluir.Text));
                MessageBox.Show("Excluído com sucesso!");
            }
            else
            {
                MessageBox.Show("Digite um número de registro para excluir!");
            }
            txtExcluir.Text = "";
            dataGridView1.Rows.Clear();
        }
    }
}
