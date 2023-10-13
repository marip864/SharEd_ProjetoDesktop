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
    public partial class AtualizacaoDiretor : Form
    {
        int opcao=0;
        public AtualizacaoDiretor(int op)
        {
            InitializeComponent();
            if (op == 1)
            {
                opcao = 1;
            }
            if (op == 2)
            {
                button1.Visible = false;
                opcao = 2;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nr = int.Parse(txtNr.Text);
            Diretor diretor = new Diretor(txtNome.Text, txtRg.Text, txtEmail.Text, txtCargo.Text, txtTelefone.Text, nr);
            if (diretor.atualizarDiretor())
            {
                MessageBox.Show("Atualização realizada com sucesso!");
            }
        }

        private void txtNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Diretor diretor = new Diretor(int.Parse(txtNr.Text));
                MySqlDataReader dr = diretor.consultarDiretor01();
                if (dr.Read())
                {
                    txtNome.Text = dr["nome"].ToString();
                    txtRg.Text = dr["rg"].ToString();
                    txtCargo.Text = dr["cargo"].ToString();
                    txtTelefone.Text = dr["ramal"].ToString();
                    txtEmail.Text = dr["email"].ToString();
                    txtRg.Enabled = false;
                    txtNr.Enabled = false;
                    if(opcao==2)
                    {
                        txtNome.Enabled = false;
                        txtRg.Enabled = false;
                        txtCargo.Enabled = false;
                        txtTelefone.Enabled = false;
                        txtEmail.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Diretor não cadastrado!");
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
