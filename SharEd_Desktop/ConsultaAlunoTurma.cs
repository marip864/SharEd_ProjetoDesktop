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
    public partial class ConsultaAlunoTurma : Form
    {
        public ConsultaAlunoTurma()
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
           
            dataGridView1.Rows.Clear();
            Turma t = new Turma();
            AlunoTurma at = new AlunoTurma();
            at.Id_turma = t.selecionaIdTurma(cbxTurma.Text);
            MySqlDataReader dr = at.consultarAlunosEmUmaTurma();
            while (dr.Read())
                dataGridView1.Rows.Add(dr["nome"].ToString());
                
            DAO_Conexao.con.Close();
            
        }
    }
}
