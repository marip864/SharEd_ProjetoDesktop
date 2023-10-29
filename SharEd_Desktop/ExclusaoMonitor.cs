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
    public partial class ExclusaoMonitor : Form
    {
        public ExclusaoMonitor()
        {
            InitializeComponent();
        }

        private void txtExcluir_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridView1.Rows.Clear();
            if (e.KeyChar == 13)
            {
                Monitor con_m = new Monitor();

                MySqlDataReader r = con_m.consultarMonitorRa(int.Parse(txtExcluir.Text));

                if (r.Read())
                {
                    dataGridView1.Rows.Add(r["nome"].ToString(), r["area"].ToString());
                }
                else
                {
                    MessageBox.Show("Monitor não cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtExcluir.Text = "";
                }

                DAO_Conexao.con.Close();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtExcluir.Text != "")
            {
                Monitor monitor = new Monitor();
                monitor.excluirMonitor(int.Parse(txtExcluir.Text));
                MessageBox.Show("Excluído com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("Digite um ra para excluir!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            txtExcluir.Text = "";
            dataGridView1.Rows.Clear();
        }
    }
}
