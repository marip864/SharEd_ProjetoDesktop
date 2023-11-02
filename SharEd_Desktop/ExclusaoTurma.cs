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
    public partial class ExclusaoTurma : Form
    {
        public ExclusaoTurma()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            Turma con_t = new Turma(cbxCurso.Text);

            MySqlDataReader r = con_t.consultarTurmaCurso();

            while (r.Read())
            {
                dataGridView1.Rows.Add(r["curso"].ToString(), r["serie"].ToString(), r["periodo"].ToString());
            }
            
            DAO_Conexao.con.Close();
            
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
               Turma turma = new Turma();
                string curso = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                int serie = int.Parse(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                string periodo = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                if (turma.excluirTurma(curso,serie,periodo))
                    MessageBox.Show("Excluído com sucesso! ", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }
    }
}
