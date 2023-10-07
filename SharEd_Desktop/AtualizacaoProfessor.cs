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
    public partial class AtualizacaoProfessor : Form
    {
        public AtualizacaoProfessor()
        {
            InitializeComponent();
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            Professor prof = new Professor(txtRg.Text);
            if (e.KeyChar == 13)
            {
                MySqlDataReader dr = prof.consultarProfessor01();
                if (dr.Read())
                {
                    txtNome.Text = dr["nome"].ToString();
                    txtNr.Text = dr["numero"].ToString();
                    txtSerie.Text = dr["serie"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                    txtMaterias.Text = dr["materia"].ToString();
                    txtTelefone.Text = dr["telefone"].ToString();
                    txtSerie.Text = dr["serie"].ToString();
                    txtRg.Enabled = false;
                    txtNr.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Professor não cadastrado!");
                }
                DAO_Conexao.con.Close();
                /*int n = aluno.verificaAtivo();
                if (n == 1)
                {
                    button2.Enabled = true;
                }
                else
                {
                    button2.Enabled = false;
                }*/

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int nr = int.Parse(txtNr.Text);
            Professor prof = new Professor(txtNome.Text, txtRg.Text, txtSerie.Text, txtMaterias.Text, txtTelefone.Text, txtEmail.Text, nr);
            if (prof.atualizarProfessor())
            {
                MessageBox.Show("Atualização realizada com sucesso!");
            }
        }
    }
}
