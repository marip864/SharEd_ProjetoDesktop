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
    public partial class ConsultaDisciplina : Form
    {
        public ConsultaDisciplina()
        {
            InitializeComponent();
        }

        private void cbxArea_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxDisciplina.Items.Clear();
            dataGridView1.Rows.Clear();
            cbxDisciplina.Text = "";
            cbxDisciplina.Enabled = true;
            Disciplina disc = new Disciplina();
            MySqlDataReader dr = disc.consultarDisciplinasArea(cbxArea.Text);
            while (dr.Read())
                cbxDisciplina.Items.Add(dr["nomeDisciplina"].ToString());
            DAO_Conexao.con.Close();

        }

        private void cbxDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            TemaDisciplina tema = new TemaDisciplina();
            MySqlDataReader dr = tema.consultarTemaDisciplina(cbxDisciplina.Text);
            if (dr.Read())
                dataGridView1.Rows.Add(dr["nome"].ToString());
            else
            {
                MessageBox.Show("Ainda não há temas cadastrados para essa disciplina!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            DAO_Conexao.con.Close();
        }
    }
}
