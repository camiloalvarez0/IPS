using System;
using Entity;
using DAL;
using Oracle.ManagedDataAccess.Client;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteServiceOracle
    {
        LiquidacionRepositoryOracle repositoryOracle;
        OracleConnection Connection;



        public ClienteServiceOracle()
        {
            string cadena = "Data Source=desktop-0pjbv6q;User ID=camilo;Password=admin;";
            Connection = new OracleConnection(cadena);
            repositoryOracle = new LiquidacionRepositoryOracle(Connection);



        }
        public class Respuesta
        {
            public string mensaje
            {
                get; set;

            }
            public bool error
            {
                get; set;
            }


        }
        public Respuesta Guardar(LiquidacionCuotaModeradora liquidacion)
        {
            var respuesta = new Respuesta();
            respuesta.error = false;// si es falso el error, guarda
            try
            {
                Connection.Open();
                repositoryOracle.Guardar(liquidacion);
                respuesta.mensaje = $"Se guardó el registro exitosamente";
                return respuesta;
            }
            catch (Exception e)
            {
                Connection.Close();
                respuesta.error = true;
                respuesta.mensaje = $"Hubo un error Guardando el Registro" + e.Message.ToString();//atrapa el mensaje de error y lo envia también de ñapa pa saber cual e
                return respuesta;

            }
            finally
            {
                Connection.Close();

            }
        }
        public IList<LiquidacionCuotaModeradora> Consultar()
        {

            try
            {
                Connection.Open();
                return repositoryOracle.Consultar();
            }
            catch (Exception)
            {
                Connection.Close();
                return null;

            }
            finally
            {
                Connection.Close();


            }

        }

        public string Eliminar(string numeroliquidacion)
        {

            Connection.Open();
            string mensaje = repositoryOracle.Eliminar(numeroliquidacion);

            Connection.Close();
            return mensaje;
        }




        public LiquidacionCuotaModeradora BuscarID(string numeroliquidacion)
        {
            LiquidacionCuotaModeradora liquidacion;
            liquidacion = new Contributivo();
            try
            {
                Connection.Open();
                return repositoryOracle.Buscar(numeroliquidacion);
            }
            catch (Exception e)
            {
                string mensaje = " ERROR EN LA BASE DE DATOS " + e.Message;
                return null;
            }
            finally
            {
                Connection.Close();
            }
        }

    }
}
