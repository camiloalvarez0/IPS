using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class LiquidacionCuotaModeradora
    {
        public string NumeroLiquidacion { get; set; }
        public DateTime FechaLiquidacion { get; set; }
        public string Identificacion { get; set; }
        public string PrimerNombre { get; set; }
        public string PrimerApellido { get; set; }
        public string TipoAfiliacion { get; set; }
        public decimal SalarioDevengado { get; set; }
        public decimal ValorServicioHospitalizacion { get; set; }
        public decimal CuotaModeradoraFinal { get; set; }
        public decimal CuotaModeradoraReal { get; set; }
        public decimal Tarifa { get; set; }
        public string AplicaTope { get; set; }
        public decimal SalarioMinimo;
        public abstract void CalcularTarifa();
        public override string ToString()
        {
            return $"{NumeroLiquidacion};{FechaLiquidacion};{Identificacion};{PrimerNombre};{PrimerApellido};{TipoAfiliacion};{SalarioDevengado};{ValorServicioHospitalizacion};{CuotaModeradoraFinal};{CuotaModeradoraReal};{Tarifa};{AplicaTope}";
        }
    }
}
