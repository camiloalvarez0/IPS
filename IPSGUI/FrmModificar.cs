using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using BLL;

namespace IPSGUI
{
    public partial class FrmModificar : Form
    {

        public FrmModificar()
        {
            InitializeComponent();
        }

        private void FrmModificar_Load(object sender, EventArgs e)
        {

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            LiquidacionCuotaModeradoraService liquidacionCuota = new LiquidacionCuotaModeradoraService();
            string numeroLiquidacion = TxtNumeroLiquidacion.Text.Trim();
            if (numeroLiquidacion != "")
            {
                LiquidacionCuotaModeradora liquidacion = liquidacionCuota.BuscarID(numeroLiquidacion);
                if (liquidacion != null)
                {
                    TxtIdentificacion.Text = liquidacion.Identificacion;
                    TxtSalarioDevengado.Text = liquidacion.SalarioDevengado.ToString();
                    TxtValorHospitalizacion.Text = liquidacion.ValorServicioHospitalizacion.ToString();
                    TxtTipoAfiliacion.Text = liquidacion.TipoAfiliacion;
                    TxtPrimerNombre.Text = liquidacion.PrimerNombre;
                    TxtPrimerApellido.Text = liquidacion.PrimerApellido;
                    DtpFechaLiquidacion.Value = liquidacion.FechaLiquidacion;
                }
                else
                {
                    MessageBox.Show($"La liquidacion numero:  {numeroLiquidacion} no esta registrada");
                }
            }
            else
            {
                MessageBox.Show("Digite numero de la liquidacion");
            }
        }
        private void limpiar()
        {
            TxtIdentificacion.Text = "";
            TxtNumeroLiquidacion.Text = "";
            TxtPrimerApellido.Text = "";
            TxtPrimerNombre.Text = "";
            TxtPrimerApellido.Text = "";
            TxtSalarioDevengado.Text = "";

        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            LiquidacionCuotaModeradoraService service = new LiquidacionCuotaModeradoraService();
            if (TxtTipoAfiliacion.Text.Equals("Contributivo"))
            {

                LiquidacionCuotaModeradora moderadora = new Contributivo();
                moderadora.NumeroLiquidacion = TxtNumeroLiquidacion.Text.Trim();
                moderadora.Identificacion = TxtIdentificacion.Text.Trim();
                moderadora.PrimerNombre = TxtPrimerNombre.Text.Trim();
                moderadora.PrimerApellido = TxtPrimerApellido.Text.Trim();

                moderadora.FechaLiquidacion = DtpFechaLiquidacion.Value;
                moderadora.SalarioDevengado = decimal.Parse(TxtSalarioDevengado.Text.Trim());
                moderadora.TipoAfiliacion = TxtTipoAfiliacion.Text.Trim();
                moderadora.ValorServicioHospitalizacion = decimal.Parse(TxtValorHospitalizacion.Text.Trim());
                moderadora.CalcularTarifa();
                service.Modificar(moderadora);
                MessageBox.Show("SE MODIFICO CORRECTAMENTE EL REGISTRO");

            }
            else if (TxtTipoAfiliacion.Text.Equals("Subsidiado"))
            {

                LiquidacionCuotaModeradora Subsidiado = new Subsidiado();
                Subsidiado.NumeroLiquidacion = TxtNumeroLiquidacion.Text.Trim();
                Subsidiado.Identificacion = TxtIdentificacion.Text.Trim();
                Subsidiado.PrimerApellido = TxtPrimerApellido.Text.Trim();
                Subsidiado.FechaLiquidacion = DtpFechaLiquidacion.Value;
                Subsidiado.FechaLiquidacion = DtpFechaLiquidacion.Value;
                Subsidiado.SalarioDevengado = decimal.Parse(TxtSalarioDevengado.Text.Trim());
                Subsidiado.TipoAfiliacion = TxtTipoAfiliacion.Text.Trim();
                Subsidiado.ValorServicioHospitalizacion = decimal.Parse(TxtValorHospitalizacion.Text.Trim());
                Subsidiado.CalcularTarifa();
                service.Modificar(Subsidiado);
                MessageBox.Show("SE MODIFICO CORRECTAMENTE EL REGISTRO");
            }
        }
    }
}
