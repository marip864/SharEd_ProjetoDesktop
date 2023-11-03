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
    public partial class ReativarTurma : Form
    {
        public ReativarTurma()
        {
            InitializeComponent();

            Turma con_t = new Turma();

            MySqlDataReader r = con_t.consultarTurmasDesativadas();

            while (r.Read())
            {
                dataGridView1.Rows.Add(r["nomeTurma"].ToString());
            }

            DAO_Conexao.con.Close();
        }

        private void btnReativar_Click(object sender, EventArgs e)
        {
            try
            {
                Turma turma = new Turma();
                if(turma.tornarAtivo(dataGridView1.CurrentCell.Value.ToString())) 
                {
                    MessageBox.Show("Ativada com sucesso! ", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridView1.Rows.Clear();
                    DAO_Conexao.con.Close();
                    MySqlDataReader r = turma.consultarTurmasDesativadas();

                    while (r.Read())
                    {
                        dataGridView1.Rows.Add(r["nomeTurma"].ToString());
                    }

                    DAO_Conexao.con.Close();
                }
                else
                {
                    MessageBox.Show("Erro! ", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    dataGridView1.Rows.Clear();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Erro! ", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
