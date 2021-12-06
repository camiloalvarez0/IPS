using System;
using Entity;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LiquidacionRepositoryOracle
    {
        private OracleConnection conection;
        IList<LiquidacionCuotaModeradora> liquidaciones = new List<LiquidacionCuotaModeradora>();
        public IList<LiquidacionCuotaModeradora> Consultar()
        {
            using (var commando = conection.CreateCommand())
            {
                commando.CommandText = "PKG_CONSULTAR.CONSULTAR_lIQUIDACION";
                commando.CommandType = CommandType.StoredProcedure;
                commando.Parameters.Add("CURSORMEMORIA", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                using (var reader = commando.ExecuteReader())
                {
                    liquidaciones.Clear();
                    while (reader.Read())
                    {
                        LiquidacionCuotaModeradora liquidacion = new Contributivo();
                        liquidacion = Mapear(reader);
                        liquidaciones.Add(liquidacion);
                    }
                }
            }
            return liquidaciones;
        }


        public LiquidacionRepositoryOracle(OracleConnection oracleConnecion)
        {
            conection = oracleConnecion;

        }
        public void Guardar(LiquidacionCuotaModeradora liquidacion)
        {
            using (var commando = conection.CreateCommand())
            {
                commando.CommandText = "PKG_INSERTAR.INSERTAR_LIQUIDACION";
                commando.CommandType = CommandType.StoredProcedure;// el que lo almacena
                commando.Parameters.Add(":NumeroLiquidacion", OracleDbType.Varchar2).Value = liquidacion.NumeroLiquidacion;
                commando.Parameters.Add(":FechaLiquidacion", OracleDbType.Date).Value = liquidacion.FechaLiquidacion;
                commando.Parameters.Add(":Identificacion", OracleDbType.Varchar2).Value = liquidacion.Identificacion;
                commando.Parameters.Add(":PrimerNombre", OracleDbType.Varchar2).Value = liquidacion.PrimerNombre;
                commando.Parameters.Add(":PrimerApellido", OracleDbType.Varchar2).Value = liquidacion.PrimerApellido;
                commando.Parameters.Add(":TipoAfiliacion", OracleDbType.Varchar2).Value = liquidacion.TipoAfiliacion;
                commando.Parameters.Add(":SalarioDevengado", OracleDbType.Decimal).Value = liquidacion.SalarioDevengado;
                commando.Parameters.Add(":ValorServicioHospitalizacion", OracleDbType.Decimal).Value = liquidacion.ValorServicioHospitalizacion;
                commando.Parameters.Add(":CuotaModeradoraFinal", OracleDbType.Decimal).Value = liquidacion.CuotaModeradoraFinal;
                commando.Parameters.Add(":CuotaModeradoraReal", OracleDbType.Decimal).Value = liquidacion.CuotaModeradoraReal;
                commando.Parameters.Add(":Tarifa", OracleDbType.Decimal).Value = liquidacion.Tarifa;
                commando.Parameters.Add(":AplicaTope", OracleDbType.Varchar2).Value = liquidacion.AplicaTope;
                commando.Parameters.Add(":SalarioMinimo", OracleDbType.Decimal).Value = liquidacion.SalarioMinimo;
                commando.ExecuteNonQuery();
            }
        }
        public LiquidacionCuotaModeradora Mapear(OracleDataReader reader)
        {
            var liquidacion = new Contributivo();
            liquidacion.NumeroLiquidacion = Convert.ToString(reader["NumeroLiquidacion"]);
            liquidacion.FechaLiquidacion = (DateTime)reader["FechaLiquidacion"];
            liquidacion.Identificacion = Convert.ToString(reader["Identificacion"]);
            liquidacion.PrimerNombre = Convert.ToString(reader["PrimerNombre"]);
            liquidacion.PrimerApellido = Convert.ToString(reader["PrimerApellido"]);
            liquidacion.TipoAfiliacion = Convert.ToString(reader["TipoAfiliacion"]);
            liquidacion.SalarioDevengado = Convert.ToDecimal(reader["SalarioDevengado"]);
            liquidacion.ValorServicioHospitalizacion = Convert.ToDecimal(reader["ValorServicioHospitalizacion"]);
            liquidacion.CuotaModeradoraFinal = Convert.ToDecimal(reader["CuotaModeradoraFinal"]);
            liquidacion.CuotaModeradoraReal = Convert.ToDecimal(reader["CuotaModeradoraReal"]);
            liquidacion.Tarifa = Convert.ToDecimal(reader["Tarifa"]);
            liquidacion.AplicaTope = Convert.ToString(reader["AplicaTope"]);
            liquidacion.SalarioMinimo = Convert.ToDecimal(reader["SalarioMinimo"]);
            return liquidacion;


        }


        public string Eliminar(string numeroliquidacion)
        {
            string result = string.Empty;
            try
            {

                using (var command = conection.CreateCommand())
                {
                    command.CommandText = "DELETE_LIQUIDACION";
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(":L_LIQUIDACION", OracleDbType.Varchar2).Value = numeroliquidacion;
                    command.Parameters.Add(new OracleParameter("P_RESULT", OracleDbType.Varchar2, 50)).Direction = ParameterDirection.Output;
                    command.ExecuteNonQuery();
                    result = Convert.ToString(command.Parameters["P_RESULT"].Value);
                }

            }
            catch (Exception)
            {
                throw;
            }
            return result;
        }

        public LiquidacionCuotaModeradora Buscar(string numeroliquidacion)
        {


            using (var command = conection.CreateCommand())
            {
                command.CommandText = "SELECT_LIQUIDACION_ID";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(":L_LIQUIDACION", OracleDbType.Varchar2).Value = numeroliquidacion;
                command.Parameters.Add("L_CURSOR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                using (var reader = command.ExecuteReader())
                {

                    reader.Read();
                    return Mapear(reader);

                }
            }
        }




    }

}
