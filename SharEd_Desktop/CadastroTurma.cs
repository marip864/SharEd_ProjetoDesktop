using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharEd_Desktop
{
    public partial class CadastroTurma : Form
    {
        public CadastroTurma()
        {
            InitializeComponent();
        }

        private void cbxSerie_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCurso.Enabled = true;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Turma turma = new Turma(cbxCurso.Text, 0, cbxPeriodo.Text, "");
                if ((cbxCurso.Text == "") || (cbxSerie.Text == "") || (cbxPeriodo.Text == ""))
                {
                    MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (cbxSerie.Text.Equals("1° ano"))
                    {
                        turma.Serie = 1;
                    }
                    else if (cbxSerie.Text.Equals("2° ano"))
                    {
                        turma.Serie = 2;
                    }
                    else if (cbxSerie.Text.Equals("3° ano"))
                    {
                        turma.Serie = 3;
                    }
                    else
                    {
                        turma.Serie = 4;
                    }
                    if (!turma.consultarTurma())
                    {
                        string nome = string.Concat(turma.Serie.ToString() + "° ano - " + turma.Curso + ": " + turma.Periodo);
                        turma.Nome = nome;
                        if (turma.cadastrarTurma())
                        {
                            MessageBox.Show("Cadastro realizado com sucesso!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            cbxCurso.Text = "";
                            cbxSerie.Text = "";
                            cbxPeriodo.Text = "";
                            cbxPeriodo.Enabled = false;
                            cbxCurso.Enabled = false;
                        }
                        else
                            MessageBox.Show("Erro no cadastro!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else
                    {
                        MessageBox.Show("A turma já está cadastrada!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        cbxCurso.Text = "";
                        cbxPeriodo.Text = "";
                        cbxSerie.Text = "";
                        cbxCurso.Enabled = false;
                        cbxPeriodo.Enabled = false;
                    }
                        
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Preencha todos os campos!", "Shar.Ed!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void cbxCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxPeriodo.Enabled = true;
        }
    }
}
