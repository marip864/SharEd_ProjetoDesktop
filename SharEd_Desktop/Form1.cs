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
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) &&(Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroAdministrador filho = new CadastroAdministrador();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroAluno filho = new CadastroAluno();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void monitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroMonitor filho = new CadastroMonitor();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroProfessor filho = new CadastroProfessor();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void administradorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ExclusaoAdministrador filho = new ExclusaoAdministrador();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ExclusaoAluno filho = new ExclusaoAluno();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void professorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ExclusaoProfessor filho = new ExclusaoProfessor();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void diretorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroDiretor filho = new CadastroDiretor();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void administradorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoAdministrador filho = new AtualizacaoAdministrador(1);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void alunoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoAluno filho = new AtualizacaoAluno(1);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void professorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoProfessor filho = new AtualizacaoProfessor(1);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void diretorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ExclusaoDiretor filho = new ExclusaoDiretor();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void administradorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
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

        }

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            int tipo = DAO_Conexao.verLogin(textBox3.Text, textBox4.Text);
            if (tipo == 0)
                MessageBox.Show("Usuário/Senha inválidos");
            else
            {
                groupBox2.Visible = false;
                menuStrip1.Visible = true;
                pictureBox2.Visible = false;
                if (tipo == 2)
                {
                    administradorToolStripMenuItem1.Enabled = false;
                    administradorToolStripMenuItem2.Enabled = false;
                    administradorToolStripMenuItem3.Enabled = false;
                }
            }
        }

        private void alunoToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void monitorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoMonitor filho = new AtualizacaoMonitor(1);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void monitorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ExclusaoMonitor filho = new ExclusaoMonitor();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void alunoToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoAluno filho = new AtualizacaoAluno(2);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void monitorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoMonitor filho = new AtualizacaoMonitor(2);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void professorToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoProfessor filho = new AtualizacaoProfessor(2);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void diretorToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoDiretor filho = new AtualizacaoDiretor(2);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void administradorToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                AtualizacaoAdministrador filho = new AtualizacaoAdministrador(2);
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void cadastrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroDisciplina filho = new CadastroDisciplina();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void cadastrarTemasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroTema filho = new CadastroTema();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void atualizarTemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ConsultaDisciplina filho = new ConsultaDisciplina();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void cadastrarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroTurma filho = new CadastroTurma();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ExclusaoTurma filho = new ExclusaoTurma();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cadastrarToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            
        }

        private void alunoEmTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void professorEmTurmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastrarToolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroAlunoTurma filho = new CadastroAlunoTurma();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void cadastrarToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                CadastroProfessorTurma filho = new CadastroProfessorTurma();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void excluirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ExclusaoAlunoTurma filho = new ExclusaoAlunoTurma();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void excluirToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ExclusaoProfessorTurma filho = new ExclusaoProfessorTurma();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void reativarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ReativarTurma filho = new ReativarTurma();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ConsultaAlunoTurma filho = new ConsultaAlunoTurma();
                filho.MdiParent = this;
                filho.Show();
            }
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if ((Application.OpenForms.OfType<CadastroTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAlunoTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessorTurma>().Count() == 0) && (Application.OpenForms.OfType<CadastroDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroTema>().Count() == 0) && (Application.OpenForms.OfType<ConsultaDisciplina>().Count() == 0) && (Application.OpenForms.OfType<CadastroAluno>().Count() == 0) && (Application.OpenForms.OfType<CadastroMonitor>().Count() == 0) && (Application.OpenForms.OfType<CadastroProfessor>().Count() == 0) && (Application.OpenForms.OfType<CadastroDiretor>().Count() == 0) && (Application.OpenForms.OfType<CadastroAdministrador>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAluno>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<AtualizacaoAdministrador>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAluno>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoMonitor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoProfessor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoDiretor>().Count() == 0) && (Application.OpenForms.OfType<ExclusaoAdministrador>().Count() == 0))
            {
                ConsultaProfessorTurma filho = new ConsultaProfessorTurma();
                filho.MdiParent = this;
                filho.Show();
            }
        }
    }
}
