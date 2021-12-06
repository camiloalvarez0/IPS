using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DAL;
using Entity;

namespace BLL
{
    public class LiquidacionServiceBd
    {
        List<LiquidacionCuotaModeradora> liquidaciones;
        SqlConnection connection;
        string cadenaconexion = "Data Source=DESKTOP-0PJBV6Q\\SQLEXPRESS;Initial Catalog=BDIPS;Integrated Security=True";
        LiquidacionRepositoryBd repository;
        public LiquidacionServiceBd()
        {
            connection = new SqlConnection(cadenaconexion);
            repository = new LiquidacionRepositoryBd(connection);

        }
        public string Guardar(LiquidacionCuotaModeradora liquidacion)
        {
            try
            {
                connection.Open();
               repository.Guardar(liquidacion);
                return "se guardo la liquidacion correctamente";

            }
            catch (Exception ex)
            {

                return "error de datos: " + ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }
       


    }

}
