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
    public class UsuarioServiceOracle
    {
        UsuarioRepositoryOraclecs repositoryOraclecs;
        OracleConnection Connection;
        public UsuarioServiceOracle()
        {
            string cadena = "Data Source=desktop-0pjbv6q;User ID=camilo;Password=admin;";
            Connection = new OracleConnection(cadena);
            repositoryOraclecs = new UsuarioRepositoryOraclecs(Connection);
        }

        public usuario BuscarID(string usuario, string pass)
        {
            
            try
            {
                Connection.Open();
                return repositoryOraclecs.Buscar(usuario,pass);
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
