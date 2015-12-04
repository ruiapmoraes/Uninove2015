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
            telaCargoPrin.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
