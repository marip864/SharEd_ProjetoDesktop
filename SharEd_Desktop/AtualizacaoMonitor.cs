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
    public partial class AtualizacaoMonitor : Form
    {
        public AtualizacaoMonitor()
        {
            InitializeComponent();
        }

        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            Monitor monitor = new Monitor(txtRg.Text);
            if (e.KeyChar == 13)
            {
                MySqlDataReader dr = monitor.consultarMonitor01();
                if (dr.Read())
                {
                    txtNome.Text = dr["nome"].ToString();
                    txtRa.Text = dr["ra"].ToString();
                    txtSerie.Text = dr["classe"].ToString();
                    txtNascimento.Text = dr["dataNascimento"].ToString();
                    txtTelefone.Text = dr["celular"].ToString();
                    txtEmail.Text = dr["emailInstitucional"].ToString();
                    txtDisciplina.Text = dr["area"].ToString();
                    txtRg.Enabled = false;
                    txtRa.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Monitor não cadastrado!");
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
            int ra = int.Parse(txtRa.Text);
            int serie = int.Parse(txtSerie.Text);
            Monitor monitor = new Monitor(txtNome.Text, txtRg.Text, txtNascimento.Text, txtTelefone.Text, txtEmail.Text, txtDisciplina.Text, ra, serie);
            if (monitor.atualizarMonitor())
            {
                MessageBox.Show("Atualização realizada com sucesso!");
            }
        }
    }
}
