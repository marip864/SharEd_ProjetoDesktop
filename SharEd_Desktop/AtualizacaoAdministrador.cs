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
    public partial class AtualizacaoAdministrador : Form
    {
        int opcao=0;
        public AtualizacaoAdministrador(int op)
        {
            InitializeComponent();
            if(op == 1)
            {
                opcao=1;
            }
            if(op == 2)
            {
                opcao=2;
                btnAtualizar.Visible = false;
            }
            
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int nr = int.Parse(txtNr.Text);
            Administrador admin = new Administrador(txtNome.Text, txtRg.Text, txtEmail.Text, txtCargo.Text, txtTelefone.Text, nr);
            if (admin.atualizarAdministrador())
            {
                MessageBox.Show("Atualização realizada com sucesso!");
            }
        }

        private void txtNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Administrador admin = new Administrador(int.Parse(txtNr.Text));
                MySqlDataReader dr = admin.consultarAdministrador01();
                if (dr.Read())
                {
                    txtNome.Text = dr["nome"].ToString();
                    txtRg.Text = dr["rg"].ToString();
                    txtCargo.Text = dr["cargo"].ToString();
                    txtTelefone.Text = dr["ramal"].ToString();
                    txtEmail.Text = dr["emailInstitucional"].ToString();
                    txtRg.Enabled = false;
                    txtNr.Enabled = false;
                    if(opcao==2)
                    {
                        txtNome.Enabled = false;
                        txtRg.Enabled=false;
                        txtCargo.Enabled = false;
                        txtTelefone.Enabled = false;
                        txtEmail.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Aluno não cadastrado!");
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
