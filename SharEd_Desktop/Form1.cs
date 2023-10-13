using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharEd_Desktop
{
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            Thread thread = new Thread(new ThreadStart(splashScreen));
            thread.Start();
            Thread.Sleep(5000); 

            InitializeComponent();

            thread.Abort();

            if (DAO_Conexao.getConexao("143.106.241.3", "cl202239", "cl202239", "@marip.864_frozen0905"))
                Console.WriteLine("Conectado");
            else
                Console.WriteLine("Erro de conexão");

            menuStrip1.Visible = false;

            
        }

        private void splashScreen()
        {
            Application.Run(new SplashScreen());
        }

        private void administradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroAdministrador filho = new CadastroAdministrador();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroAluno filho = new CadastroAluno();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroMonitor filho = new CadastroMonitor();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroProfessor filho = new CadastroProfessor();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void administradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ExclusaoAdministrador filho = new ExclusaoAdministrador();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ExclusaoAluno filho = new ExclusaoAluno();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void professorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ExclusaoProfessor filho = new ExclusaoProfessor();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void diretorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroDiretor filho = new CadastroDiretor();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void administradorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoAdministrador filho = new AtualizacaoAdministrador(1);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void alunoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoAluno filho = new AtualizacaoAluno(1);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void professorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoProfessor filho = new AtualizacaoProfessor(1);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void diretorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ExclusaoDiretor filho = new ExclusaoDiretor();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void administradorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ExclusaoAdministrador filho = new ExclusaoAdministrador();
                filho.MdiParent = this;
                filho.Show();
            }
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
                menuStrip1.Visible = true;
                administradorToolStripMenuItem1.Enabled = false;
                administradorToolStripMenuItem2.Enabled = false;
                administradorToolStripMenuItem3.Enabled = false;
            }
        }

        private void alunoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void monitorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoMonitor filho = new AtualizacaoMonitor(1);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void monitorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ExclusaoMonitor filho = new ExclusaoMonitor();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void alunoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoAluno filho = new AtualizacaoAluno(2);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void monitorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoMonitor filho = new AtualizacaoMonitor(2);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void professorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoProfessor filho = new AtualizacaoProfessor(2);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void diretorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoDiretor filho = new AtualizacaoDiretor(2);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void administradorToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoAdministrador filho = new AtualizacaoAdministrador(2);
                filho.MdiParent = this;
                filho.Show();
            }
        }
    }
}
