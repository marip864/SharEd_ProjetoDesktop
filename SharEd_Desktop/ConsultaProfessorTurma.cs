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
    public partial class ConsultaProfessorTurma : Form
    {
        public ConsultaProfessorTurma()
        {
            InitializeComponent();
            Turma con_t = new Turma(cbxTurma.Text);

            MySqlDataReader r = con_t.consultarTurmasPeloNome();

            while (r.Read())
            {
                cbxTurma.Items.Add(r["nomeTurma"].ToString());
            }

            DAO_Conexao.con.Close();
        }

        private void cbxTurma_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            Turma t = new Turma();
            ProfessorTurma at = new ProfessorTurma();
            at.Id_turma = t.selecionaIdTurma(cbxTurma.Text);
            MySqlDataReader dr = at.consultarProfsEmUmaTurma();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["nome"].ToString(), dr["materia"].ToString());
                i++;
            }
            if(i==0)
            {
                MessageBox.Show("Ainda não há professores cadastrados para essa turma!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                

            DAO_Conexao.con.Close();
        }
    }
}
