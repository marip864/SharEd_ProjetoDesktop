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
                dataGridView1.Rows.Add(r["nomeTurma"].ToString());
            }
            
            DAO_Conexao.con.Close();            
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
             Turma turma = new Turma();
             if (turma.excluirTurma(dataGridView1.CurrentCell.Value.ToString(),turma.selecionaIdTurma(dataGridView1.CurrentCell.Value.ToString())))
                MessageBox.Show("Excluído com sucesso! ", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
             dataGridView1.Rows.Clear();
             cbxCurso.Text = "";
            
        }
    }
}
