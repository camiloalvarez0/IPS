using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data.SqlClient;

namespace DAL
{
    public class LiquidacionRepositoryBd
    {
        private SqlConnection connection;
        private List<LiquidacionCuotaModeradora> liquidaciones;
        public LiquidacionRepositoryBd(SqlConnection connectionDb)
        {
            connection = connectionDb;
            liquidaciones = new List<LiquidacionCuotaModeradora>();

        }

        public void Guardar(LiquidacionCuotaModeradora liquidacion) {
        using (var command = connection.CreateCommand())
            {
                command.CommandText = "insert into Liquidacion (NumeroLiquidacion,FechaLiquidacion,Identificacion,PrimerNombre,PrimerApellido,TipoAfiliacion,SalarioDevengado,ValorServicioHospitalizacion) Values (@NumeroLiquidacion,@FechaLiquidacion,@Identificacion,@PrimerNombre,@PrimerApellido,@TipoAfiliacion,@SalarioDevengado,@ValorServicioHospitalizacion)";
                command.Parameters.AddWithValue("@NumeroLiquidacion", liquidacion.NumeroLiquidacion);
                command.Parameters.AddWithValue("@FechaLiquidacion", liquidacion.FechaLiquidacion);
                command.Parameters.AddWithValue("@Identificacion", liquidacion.Identificacion);
                command.Parameters.AddWithValue("@PrimerNombre", liquidacion.PrimerNombre);
                command.Parameters.AddWithValue("@PrimerApellido", liquidacion.PrimerApellido);
                command.Parameters.AddWithValue("@TipoAfiliacion", liquidacion.TipoAfiliacion);
                command.Parameters.AddWithValue("@SalarioDevengado", liquidacion.SalarioDevengado);
                command.Parameters.AddWithValue("@ValorServicioHospitalizacion", liquidacion.ValorServicioHospitalizacion);
                
                command.ExecuteNonQuery();

            }
        }

    }
}
