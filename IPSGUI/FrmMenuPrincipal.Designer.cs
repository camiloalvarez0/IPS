namespace IPSGUI
{
    partial class FrmMenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevaLiquidaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaLiquidaciónToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarLiquidacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaLiquidaciónToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1262, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nuevaLiquidaciónToolStripMenuItem
            // 
            this.nuevaLiquidaciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaLiquidaciónToolStripMenuItem1,
            this.consultarLiquidacionesToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.nuevaLiquidaciónToolStripMenuItem.Name = "nuevaLiquidaciónToolStripMenuItem";
            this.nuevaLiquidaciónToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.nuevaLiquidaciónToolStripMenuItem.Text = "Archivo";
            // 
            // nuevaLiquidaciónToolStripMenuItem1
            // 
            this.nuevaLiquidaciónToolStripMenuItem1.Name = "nuevaLiquidaciónToolStripMenuItem1";
            this.nuevaLiquidaciónToolStripMenuItem1.Size = new System.Drawing.Size(198, 22);
            this.nuevaLiquidaciónToolStripMenuItem1.Text = "Nueva liquidación";
            this.nuevaLiquidaciónToolStripMenuItem1.Click += new System.EventHandler(this.nuevaLiquidaciónToolStripMenuItem1_Click);
            // 
            // consultarLiquidacionesToolStripMenuItem
            // 
            this.consultarLiquidacionesToolStripMenuItem.Name = "consultarLiquidacionesToolStripMenuItem";
            this.consultarLiquidacionesToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.consultarLiquidacionesToolStripMenuItem.Text = "Consultar liquidaciones";
            this.consultarLiquidacionesToolStripMenuItem.Click += new System.EventHandler(this.consultarLiquidacionesToolStripMenuItem_Click);
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // salirDelSistemaToolStripMenuItem1
            // 
            this.salirDelSistemaToolStripMenuItem1.Name = "salirDelSistemaToolStripMenuItem1";
            this.salirDelSistemaToolStripMenuItem1.Size = new System.Drawing.Size(103, 20);
            this.salirDelSistemaToolStripMenuItem1.Text = "Salir del sistema";
            this.salirDelSistemaToolStripMenuItem1.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 499);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenuPrincipal";
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.FrmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevaLiquidaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaLiquidaciónToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultarLiquidacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}