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
    public partial class CadastroAlunoTurma : Form
    {
        public CadastroAlunoTurma()
        {
            InitializeComponent();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtRa.Text=="")
                {
                    MessageBox.Show("Digite um RA!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Aluno a = new Aluno(int.Parse(txtRa.Text));
                    if (!a.consultarAluno())
                    {
                        MessageBox.Show("O aluno não existe!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtRa.Text = "";
                    }
                    else
                    {
                        Turma turma = new Turma();
                        AlunoTurma at = new AlunoTurma(int.Parse(txtRa.Text), turma.selecionaIdTurma(dataGridView1.CurrentCell.Value.ToString()));
                        if (at.cadastrarAlunoTurma(at.selecionaSerie()))
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtRa.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Erro no cadastro!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                dataGridView1.Rows.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtRa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {     
                dataGridView1.Rows.Clear();
            
                if (txtRa.Text == "")
                {
                    MessageBox.Show("Digite um RA!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(txtRa.Text, out n);
                    if (ehUmNumero)
                    {
                        Aluno a = new Aluno(int.Parse(txtRa.Text));
                        AlunoTurma at = new AlunoTurma(int.Parse(txtRa.Text));
                        if (!a.consultarAluno())
                        {
                            MessageBox.Show("O aluno não existe!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtRa.Text = "";
                        }

                        else if (at.consultarAlunoTurma(int.Parse(txtRa.Text)))
                        {
                            MessageBox.Show("O aluno já está vinculado a uma turma!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtRa.Text = "";
                        }
                        else
                        {
                            Turma con_t = new Turma();

                            MySqlDataReader r = con_t.consultarTurmaNome();

                            while (r.Read())
                            {
                                dataGridView1.Rows.Add(r["nomeTurma"].ToString());
                            }

                            DAO_Conexao.con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtRa.Text = "";
                    }
                }
            }
        }

        private void txtSerie_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
