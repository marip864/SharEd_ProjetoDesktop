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
    public partial class CadastroProfessorTurma : Form
    {
        public CadastroProfessorTurma()
        {
            InitializeComponent();
            
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
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
                        Professor professor = new Professor();
                        ProfessorTurma proft = new ProfessorTurma(int.Parse(txtNr.Text), turma.selecionaIdTurma(dataGridView1.CurrentCell.Value.ToString()));
                        if(!proft.consultarProfessorMateriaTurma(professor.selecionaMateria(int.Parse(txtNr.Text)),turma.selecionaIdTurma(dataGridView1.CurrentCell.Value.ToString())))
                        {
                            if (proft.cadastrarProfessorTurma())
                            {
                                MessageBox.Show("Cadastro realizado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                txtNr.Text = "";
                            }
                            else
                            {
                                MessageBox.Show("Erro no cadastro!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Já existe um professor dessa matéria na turma selecionada!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txtNr.Text = "";
                        }
                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            dataGridView1.Rows.Clear();
        }

        private void txtNr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
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
                        txtNr.Text = "";
                    }

                }
            }
        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbxSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
