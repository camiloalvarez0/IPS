using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPSGUI
{
    public partial class FrmMenuPrincipal : Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void nuevaLiquidaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLiquidacion frmLiquidacion = new FrmLiquidacion();
            frmLiquidacion.MdiParent = this;
            frmLiquidacion.Show();
        }

        private void consultarLiquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultarLiquidacion frmConsultar = new FrmConsultarLiquidacion();
            frmConsultar.MdiParent = this;
            frmConsultar.Show();
        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Realmente desea salir del sistema?", "Salir", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FrmLiquidacion frmLiquidacion = new FrmLiquidacion();
            frmLiquidacion.MdiParent = this;
            frmLiquidacion.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificar frmModificar = new FrmModificar();
            frmModificar.MdiParent = this;
            frmModificar.Show();
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmModificar frmModificar = new FrmModificar();
            frmModificar.MdiParent = this;
            frmModificar.Show();
        }

       

        private void salirDelSistemaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("¿Realmente desea salir del sistema?", "Salir", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void gestiónDeLiquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
