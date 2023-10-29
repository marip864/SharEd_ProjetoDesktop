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
                MessageBox.Show("Atualização realizada com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                    if(opcao==1)
                    {
                        txtNome.Enabled = true;
                        txtRg.Enabled=true;
                        txtCargo.Enabled = true;
                        txtTelefone.Enabled = true;
                        txtEmail.Enabled = true;
                    }
                    int n = admin.verificaAtivo();
                    if (n == 1)
                    {
                        btnAtivo.Enabled = true;
                    }
                    else
                    {
                        btnAtivo.Enabled = false;
                    }
                    int num = admin.verificaAtivo();
                    if (num == 1)
                    {
                        btnAtivo.Enabled = true;
                    }
                    else
                    {
                        btnAtivo.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("Administrador não cadastrado!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNr.Text = "";
                }
                DAO_Conexao.con.Close();
                

            }
        }

        private void btnAtivo_Click(object sender, EventArgs e)
        {
            try
            {
                int nr = int.Parse(txtNr.Text);
                Administrador a = new Administrador(nr);
                if (a.tornarAtivo())
                {
                    MessageBox.Show("Administrador ativado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Selecione uma opção para atualizar!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            DAO_Conexao.con.Close();
        }
    }
}
