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
    public partial class ExclusaoProfessorTurma : Form
    {
        public ExclusaoProfessorTurma()
        {
            InitializeComponent();
        }

        private void txtNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                dataGridView1.Rows.Clear();
                if (txtNr.Text == "")
                {
                    MessageBox.Show("Digite um NR!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    int n;
                    bool ehUmNumero = int.TryParse(txtNr.Text, out n);
                    if (ehUmNumero)
                    {
                        Professor a = new Professor(int.Parse(txtNr.Text));
                        if (!a.consultarProfessor())
                        {
                            MessageBox.Show("O professor não existe!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNr.Text = "";
                        }
                        else
                        {
                            Turma turma = new Turma();
                            ProfessorTurma at = new ProfessorTurma();
                            if (!at.consultarProfessorTurma(int.Parse(txtNr.Text)))
                            {
                                MessageBox.Show("O professor não está cadastrado em uma turma!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtNr.Text = "";
                            }

                            else
                            {
                                MySqlDataReader r = turma.consultaNomedaTurmaProfessor();
                                while (r.Read())
                                {
                                    dataGridView1.Rows.Add(r["nomeTurma"].ToString());
                                }
                                DAO_Conexao.con.Close();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite um número!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNr.Text = "";
                    }
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNr.Text == "")
                {
                    MessageBox.Show("Digite um NR!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Turma turma = new Turma();
                    ProfessorTurma at = new ProfessorTurma();
                    if (at.excluirProfessorTurma(int.Parse(txtNr.Text),turma.selecionaIdTurma(dataGridView1.CurrentCell.Value.ToString())))
                    {
                        MessageBox.Show("Excluído com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtNr.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Erro na exclusão!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro na exclusão!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dataGridView1.Rows.Clear();
        }
    }
}
