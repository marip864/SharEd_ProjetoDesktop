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
    public partial class AtualizacaoAluno : Form
    {
        public AtualizacaoAluno()
        {
            InitializeComponent();
        }


        private void txtRg_KeyPress(object sender, KeyPressEventArgs e)
        {
            Aluno aluno = new Aluno(txtRg.Text);
            if (e.KeyChar == 13)
            {
                MySqlDataReader dr = aluno.consultarAluno01();
                if (dr.Read())
                {
                    txtNome.Text = dr["nome"].ToString();
                    txtRa.Text = dr["ra"].ToString();
                    txtSerie.Text = dr["classe"].ToString();
                    txtNascimento.Text = dr["dataNascimento"].ToString();
                    txtTelefone.Text = dr["celular"].ToString();
                    txtEmail.Text = dr["emailInstitucional"].ToString();
                    txtRg.Enabled = false;
                    txtRa.Enabled = false;
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            int ra = int.Parse(txtRa.Text);
            int serie = int.Parse(txtSerie.Text);
            Aluno aluno = new Aluno(txtNome.Text, txtRg.Text, txtNascimento.Text, txtTelefone.Text, txtEmail.Text, ra, serie);
            if (aluno.atualizarAluno())
            {
                MessageBox.Show("Atualização realizada com sucesso!");
            }
        }
    }
}
