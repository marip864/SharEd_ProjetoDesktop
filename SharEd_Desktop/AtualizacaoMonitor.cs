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
        int opcao = 0;
        public AtualizacaoMonitor(int op)
        {
            InitializeComponent();
            if (op == 1)
            {
                opcao = 1;
            }
            if (op == 2)
            {
                btnAtualizar.Visible = false;
                opcao = 2;
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int ra = int.Parse(txtRa.Text);
            int serie = int.Parse(txtSerie.Text);
            Monitor monitor = new Monitor(txtNome.Text, txtRg.Text, txtNascimento.Text, txtTelefone.Text, txtEmail.Text, txtDisciplina.Text, ra, txtSerie.Text);
            if (monitor.atualizarMonitor())
            {
                MessageBox.Show("Atualização realizada com sucesso!");
            }
        }

        private void txtRa_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == 13)
            {
                Monitor monitor = new Monitor(int.Parse(txtRa.Text));
                MySqlDataReader dr = monitor.consultarMonitor01();
                if (dr.Read())
                {
                    txtNome.Text = dr["nome"].ToString();
                    txtRg.Text = dr["rg"].ToString();
                    txtSerie.Text = dr["classe"].ToString();
                    txtNascimento.Text = dr["dataNascimento"].ToString();
                    txtTelefone.Text = dr["celular"].ToString();
                    txtEmail.Text = dr["emailInstitucional"].ToString();
                    txtDisciplina.Text = dr["area"].ToString();
                    txtRg.Enabled = false;
                    txtRa.Enabled = false;
                    if(opcao==2)
                    {
                        txtNome.Enabled = false;
                        txtRg.Enabled = false;
                        txtSerie.Enabled = false;
                        txtNascimento.Enabled = false;
                        txtTelefone.Enabled = false;
                        txtEmail.Enabled = false;
                        txtDisciplina.Enabled = false;
                    }
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
    }
}
