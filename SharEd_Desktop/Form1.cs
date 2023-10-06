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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202239", "cl202239", "@marip.864_frozen0905"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de conexão");

            menuStrip1.Visible = false;
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAdministrador filho = new CadastroAdministrador();
            filho.MdiParent = this;
            filho.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroAluno filho = new CadastroAluno();
            filho.MdiParent = this;
            filho.Show();
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroProfessor filho = new CadastroProfessor();
            filho.MdiParent = this;
            filho.Show();
        }

        private void administradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExclusaoAdministrador filho = new ExclusaoAdministrador();
            filho.MdiParent = this;
            filho.Show();
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExclusaoAluno filho = new ExclusaoAluno();
            filho.MdiParent = this;
            filho.Show();
        }

        private void professorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExclusaoProfessor filho = new ExclusaoProfessor();
            filho.MdiParent = this;
            filho.Show();
        }

        private void diretorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroDiretor filho = new CadastroDiretor();
            filho.MdiParent = this;
            filho.Show();
        }

        private void administradorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AtualizacaoDiretor filho = new AtualizacaoDiretor();
            filho.MdiParent = this;
            filho.Show();
        }

        private void alunoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AtualizacaoAluno filho = new AtualizacaoAluno();
            filho.MdiParent = this;
            filho.Show();
        }

        private void professorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AtualizacaoProfessor filho = new AtualizacaoProfessor();
            filho.MdiParent = this;
            filho.Show();
        }

        private void diretorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ExclusaoDiretor filho = new ExclusaoDiretor();
            filho.MdiParent = this;
            filho.Show();
        }

        private void administradorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ExclusaoAdministrador filho = new ExclusaoAdministrador();
            filho.MdiParent = this;
            filho.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.verLogin(textBox1.Text, textBox2.Text);
            if (tipo == 0)
                MessageBox.Show("Usuário/Senha inválidos");
            if (tipo == 1)
            {
                groupBox1.Visible = false;
                menuStrip1.Visible = true;
            }
            if (tipo == 2)
            {
                groupBox1.Visible = false;
                menuStrip1.Enabled = true;
                administradorToolStripMenuItem1.Enabled = false;
                administradorToolStripMenuItem2.Enabled = false;
                administradorToolStripMenuItem3.Enabled = false;
            }
        }

        private void alunoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
