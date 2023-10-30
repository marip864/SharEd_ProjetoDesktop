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
    public partial class ExclusaoAdministrador : Form
    {
        public ExclusaoAdministrador()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtExcluir.Text != "")
            {
                Administrador admin = new Administrador();
                admin.excluirAdministrador(int.Parse(txtExcluir.Text));
                MessageBox.Show("Excluído com sucesso!","Shar.Ed!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtExcluir.Text = "";
            }
            else
            {
                MessageBox.Show("Digite um NR para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtExcluir.Text = "";
            }
            txtExcluir.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void txtExcluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (e.KeyChar==13)
            {
                if (txtExcluir.Text == "")
                {
                    MessageBox.Show("Digite um NR para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Administrador con_a = new Administrador();

                    MySqlDataReader r = con_a.consultarAdministradorNr(int.Parse(txtExcluir.Text));

                    if (r.Read())
                    {
                        dataGridView1.Rows.Add(r["nome"].ToString(), r["cargo"].ToString());
                    }
                    else
                    {
                        MessageBox.Show("Administrador não cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    DAO_Conexao.con.Close();
                }
            }
            
        }
    }
}
