namespace UninoveAcademiaSistemas.Formularios.Cadastro
{
    partial class frmCargoPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargoPrincipal));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvCargo = new System.Windows.Forms.DataGridView();
            this.CdCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsbNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.tsbSair = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbNovo,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.tsbSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(465, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvCargo);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 228);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista de Cargos";
            // 
            // dgvCargo
            // 
            this.dgvCargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CdCargo,
            this.NomeCargo});
            this.dgvCargo.Location = new System.Drawing.Point(7, 20);
            this.dgvCargo.Name = "dgvCargo";
            this.dgvCargo.ReadOnly = true;
            this.dgvCargo.Size = new System.Drawing.Size(446, 202);
            this.dgvCargo.TabIndex = 0;
            // 
            // CdCargo
            // 
            this.CdCargo.HeaderText = "Código";
            this.CdCargo.Name = "CdCargo";
            this.CdCargo.ReadOnly = true;
            // 
            // NomeCargo
            // 
            this.NomeCargo.HeaderText = "Cargo";
            this.NomeCargo.Name = "NomeCargo";
            this.NomeCargo.ReadOnly = true;
            this.NomeCargo.Width = 300;
            // 
            // tsbNovo
            // 
            this.tsbNovo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNovo.Image = ((System.Drawing.Image)(resources.GetObject("tsbNovo.Image")));
            this.tsbNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNovo.Name = "tsbNovo";
            this.tsbNovo.Size = new System.Drawing.Size(23, 22);
            this.tsbNovo.Text = "Novo";
            this.tsbNovo.Click += new System.EventHandler(this.tsbNovo_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // tsbSair
            // 
            this.tsbSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSair.Image = ((System.Drawing.Image)(resources.GetObject("tsbSair.Image")));
            this.tsbSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSair.Name = "tsbSair";
            this.tsbSair.Size = new System.Drawing.Size(23, 22);
            this.tsbSair.Text = "Sair";
            this.tsbSair.Click += new System.EventHandler(this.tsbSair_Click);
            // 
            // frmCargoPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 266);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmCargoPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Cargos";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbNovo;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton tsbSair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CdCargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCargo;
    }
}