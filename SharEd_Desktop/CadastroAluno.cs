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
    public partial class CadastroAluno : Form
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                int ra = int.Parse(txtRA.Text);
                int serie = int.Parse(cbxSerie.Text);   
                Aluno aluno = new Aluno(txtNome.Text, txtRG.Text, txtNascimento.Text, txtTelefone.Text, txtEmail.Text, ra, serie);
                if (aluno.cadastrarAluno())
                    MessageBox.Show("Cadastro realizado com sucesso!");
                else
                    MessageBox.Show("Erro no cadastro!");
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Preencha todos os campos!");
            }
            
        }
    }
}
