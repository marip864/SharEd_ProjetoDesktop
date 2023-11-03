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
    public partial class ExclusaoAlunoTurma : Form
    {
        public ExclusaoAlunoTurma()
        {
            InitializeComponent();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRa.Text == "")
                {
                    MessageBox.Show("Digite um RA!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Turma turma = new Turma();
                    AlunoTurma at = new AlunoTurma(int.Parse(txtRa.Text), turma.selecionaIdTurma(txtTurma.Text));
                    if (at.excluirAlunoTurma(int.Parse(txtRa.Text)))
                    {
                        MessageBox.Show("Excluído com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtRa.Text = "";
                        txtTurma.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Erro na exclusão!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na exclusão!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txtRa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtTurma.Text = "";
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
                        if (!a.consultarAluno())
                        {
                            MessageBox.Show("O aluno não existe!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtRa.Text = "";
                        }
                        else
                        {
                            Turma turma = new Turma();
                            AlunoTurma at = new AlunoTurma();
                            if (!at.consultarAlunoTurma(int.Parse(txtRa.Text)))
                            {
                                MessageBox.Show("O aluno não está cadastrado em uma turma!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtRa.Text = "";
                            }
                            else
                            {
                                MySqlDataReader r = turma.consultaNomedaTurma(turma.selecionaIdTurmadoAluno(int.Parse(txtRa.Text)));
                                if (r.Read())
                                {
                                    txtTurma.Text = r["nomeTurma"].ToString();
                                }

                                DAO_Conexao.con.Close();
                            }
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
    }
}
