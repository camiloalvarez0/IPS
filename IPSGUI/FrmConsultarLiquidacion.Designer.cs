namespace IPSGUI
{
    partial class FrmConsultarLiquidacion
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
            this.DgvLiquidacion = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLiquidacion)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvLiquidacion
            // 
            this.DgvLiquidacion.BackgroundColor = System.Drawing.Color.White;
            this.DgvLiquidacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLiquidacion.Location = new System.Drawing.Point(48, 76);
            this.DgvLiquidacion.Name = "DgvLiquidacion";
            this.DgvLiquidacion.Size = new System.Drawing.Size(981, 175);
            this.DgvLiquidacion.TabIndex = 0;
            this.DgvLiquidacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvLiquidacion_CellContentClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(375, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(307, 29);
            this.label8.TabIndex = 22;
            this.label8.Text = "Reporte de liquidaciones";
            // 
            // FrmConsultarLiquidacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1041, 336);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DgvLiquidacion);
            this.Name = "FrmConsultarLiquidacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmConsultarLiquidacion";
            this.Load += new System.EventHandler(this.FrmConsultarLiquidacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvLiquidacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvLiquidacion;
        private System.Windows.Forms.Label label8;
    }
}