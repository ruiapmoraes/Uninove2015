﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UninoveAcademiaSistemas.Formularios.Exercicios
{
    public partial class frmFichaExerciciosPrinc : Form
    {
        public frmFichaExerciciosPrinc()
        {
            InitializeComponent();
        }

        private void tsbNovo_Click(object sender, EventArgs e)
        {
            frmFichaExercicios telaFicha = new frmFichaExercicios();
            telaFicha.ShowDialog();

        }
    }
}
