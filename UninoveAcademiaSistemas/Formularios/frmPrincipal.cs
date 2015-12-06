using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UninoveAcademiaSistemas.Formularios.Cadastro;
using UninoveAcademiaSistemas.Formularios.Exercicios;

namespace UninoveAcademiaSistemas.Formularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cargoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCargoPrincipal telaCargoPrin = new frmCargoPrincipal();
            telaCargoPrin.MdiParent = this;
            telaCargoPrin.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncionarioPrinc telaFuncPrinc = new frmFuncionarioPrinc();
            telaFuncPrinc.ShowDialog();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAlunoPrinc telaAluno = new frmAlunoPrinc();
            telaAluno.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aulaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAulaPrinc telaAula = new frmAulaPrinc();
            telaAula.ShowDialog();
        }

        private void aulaDosInstrutoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFuncAulaPrinc telaFuncAula = new frmFuncAulaPrinc();
            telaFuncAula.ShowDialog();
        }

        private void horárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHorarioPrinc telaHorario = new frmHorarioPrinc();
            telaHorario.ShowDialog();
        }

        private void frequênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFrequenciaPrinc telaFreq = new frmFrequenciaPrinc();
            telaFreq.ShowDialog();
        }

        private void sobreToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSobre telaSobre = new frmSobre();
            telaSobre.ShowDialog();
        }

        private void fichaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFichaExerciciosPrinc telaFicha = new frmFichaExerciciosPrinc();
            telaFicha.ShowDialog();
        }

        private void medidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMedidasPrinc telaMedidas = new frmMedidasPrinc();
            telaMedidas.ShowDialog();
        }
    }
}
