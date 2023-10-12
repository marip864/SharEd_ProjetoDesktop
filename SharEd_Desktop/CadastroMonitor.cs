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
    public partial class CadastroMonitor : Form
    {
        public CadastroMonitor()
        {
            InitializeComponent();
            txtEmail.Enabled = false;
            txtNascimento.Enabled = false;
            txtNome.Enabled = false;
            txtRg.Enabled = false;
            txtTelefone.Enabled = false;

        }
        public void ativar()
        {
            txtEmail.Enabled = true;
            txtNascimento.Enabled = true;
            txtNome.Enabled = true;
            txtRg.Enabled = true;
            txtTelefone.Enabled = true;
            txtRa.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int ra = int.Parse(txtRa.Text);
                
                
                Monitor monitor = new Monitor(txtNome.Text, txtRg.Text, txtNascimento.Text, txtTelefone.Text, txtEmail.Text, cbxDisciplina.Text, ra, cbxSerie.Text);
                if (monitor.cadastrarMonitor())
                    MessageBox.Show("Cadastro realizado com sucesso!");
                else
                    MessageBox.Show("Erro no cadastro!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void txtRa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    Aluno al = new Aluno(int.Parse(txtRa.Text));
                    if (al.consultarAluno())
                        {
                            MySqlDataReader r = al.consultarAluno02();
                            while(r.Read())
                            {
                                txtEmail.Text = r["emailInstitucional"].ToString();
                                txtNascimento.Text = r["dataNascimento"].ToString();
                                txtNome.Text = r["nome"].ToString();
                                txtRg.Text = r["rg"].ToString();
                                txtTelefone.Text = r["celular"].ToString();
                            }
                        }
                    else
                    {
                        MessageBox.Show("Aluno não existe");
                    }
                    
                    
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
                finally
                {
                    DAO_Conexao.con.Close();
                }
            }
        }
    }
}
