﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UninoveAcademiaSistemas.Formularios.Cadastro
{
    public partial class frmAulaPrinc : Form
    {
        public frmAulaPrinc()
        {
            InitializeComponent();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            frmAula telaAula = new frmAula();
            telaAula.ShowDialog();
        }
    }
}
