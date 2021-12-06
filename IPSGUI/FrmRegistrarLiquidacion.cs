using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace IPSGUI
{
    public partial class FrmLiquidacion : Form
    {
        LiquidacionCuotaModeradora liquidacion;
        ClienteServiceOracle ServiceOracle = new ClienteServiceOracle();
        public FrmLiquidacion()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            validarCajas();
            LimpiarCajas();
        }
        public void validarCajas()
        {
            if(TxtNumeroLiquidacion.Text.Trim()== "" || TxtIdentificacion.Text.Trim()== "" || TxtPrimerNombre.Text.Trim()== "" || TxtPrimerApellido.Text.Trim()== "" || TxtSalarioDevengado.Text.Trim()== "" || TxtValorHospitalizacion.Text.Trim()== "")
            {
                MessageBox.Show("Algunos campos están vacios", "mensaje", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                var respuesta = new ClienteServiceOracle.Respuesta();
                LiquidacionCuotaModeradora cuotaModeradora = MapearLiquidacion();
                cuotaModeradora.CalcularTarifa();
                respuesta = ServiceOracle.Guardar(cuotaModeradora);
                MessageBox.Show(respuesta.mensaje, "resultado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }
        private LiquidacionCuotaModeradora MapearLiquidacion()
        {
            if (CmbTipoAfiliacion.Text.Equals("Contri"))
            {
                liquidacion = new Contributivo();
                liquidacion.NumeroLiquidacion = TxtNumeroLiquidacion.Text;
                liquidacion.FechaLiquidacion = DtpFechaLiquidacion.Value.Date;
                liquidacion.Identificacion = TxtIdentificacion.Text;
                liquidacion.PrimerNombre = TxtPrimerNombre.Text.Trim();
                liquidacion.PrimerApellido = TxtPrimerApellido.Text.Trim();

                liquidacion.TipoAfiliacion = CmbTipoAfiliacion.Text;
                liquidacion.SalarioDevengado = decimal.Parse(TxtSalarioDevengado.Text);
                liquidacion.ValorServicioHospitalizacion = decimal.Parse(TxtValorHospitalizacion.Text);
                return liquidacion;
            }
            if (CmbTipoAfiliacion.Text.Equals("Subsi"))
            {
                liquidacion = new Subsidiado();
                liquidacion.NumeroLiquidacion = TxtNumeroLiquidacion.Text;
                liquidacion.FechaLiquidacion = DtpFechaLiquidacion.Value.Date;
                liquidacion.Identificacion = TxtIdentificacion.Text;
                liquidacion.PrimerNombre = TxtPrimerNombre.Text.Trim();
                liquidacion.PrimerApellido = TxtPrimerApellido.Text.Trim();
                liquidacion.TipoAfiliacion = CmbTipoAfiliacion.Text;
                liquidacion.SalarioDevengado = decimal.Parse(TxtSalarioDevengado.Text);
                liquidacion.ValorServicioHospitalizacion = decimal.Parse(TxtValorHospitalizacion.Text);
                return liquidacion;
            }
            return null;
        }

        private void FrmLiquidacion_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("ESTA SEGURO DE ELIMINAR EL REGISTRO", "MENSAJE DE ELIMINACIÓN", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                ClienteServiceOracle clienteService = new ClienteServiceOracle();
                string numeroliquidacion = TxtNumeroLiquidacion.Text.Trim();
                string mensaje = clienteService.Eliminar(numeroliquidacion);
                MessageBox.Show(mensaje);

            }
            LimpiarCajas();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            ClienteServiceOracle clienteService = new ClienteServiceOracle();
            string numeroliquidacion = TxtNumeroLiquidacion.Text.Trim();
            if (numeroliquidacion != "")
            {
                LiquidacionCuotaModeradora liquidacion;
                liquidacion = new Contributivo();
                liquidacion = clienteService.BuscarID(numeroliquidacion);

                if (liquidacion != null)
                {
                    TxtNumeroLiquidacion.Text = liquidacion.NumeroLiquidacion;
                    DtpFechaLiquidacion.Text = liquidacion.FechaLiquidacion.ToString();
                    TxtIdentificacion.Text = liquidacion.Identificacion;
                    TxtPrimerNombre.Text = liquidacion.PrimerNombre;
                    TxtPrimerApellido.Text = liquidacion.PrimerApellido;
                    CmbTipoAfiliacion.Text = liquidacion.TipoAfiliacion;
                    TxtSalarioDevengado.Text = liquidacion.SalarioDevengado.ToString();
                    TxtValorHospitalizacion.Text = liquidacion.ValorServicioHospitalizacion.ToString();

                   

                }
                else
                {
                    MessageBox.Show($"LA LIQUIDACION CON NUMERO:  {numeroliquidacion} NO SE ENCUENTRA EN NUESTRA BASE DE DATOS");
                    LimpiarCajas();
                }


            }
            else
            {
                MessageBox.Show("DIGITE LA CEDULA");
            }
        }


        private void LimpiarCajas()
        {

            TxtNumeroLiquidacion.Text = "";
            TxtIdentificacion.Text = "";
            TxtPrimerNombre.Text = "";
            CmbTipoAfiliacion.Text = "SELECCIONE";
            TxtPrimerApellido.Text = "";
            TxtSalarioDevengado.Text = "";
            TxtValorHospitalizacion.Text = "";
            
        }


        private void CmbTipoAfiliacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtNumeroLiquidacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSalarioDevengado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
