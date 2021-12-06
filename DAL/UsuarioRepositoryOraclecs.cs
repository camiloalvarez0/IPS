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
    public class UsuarioRepositoryOraclecs
    {
        private OracleConnection connection;
        public UsuarioRepositoryOraclecs(OracleConnection Connection)
        {
            connection = Connection;
        }

        public usuario Buscar(string user, string pass)
        {


            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT_USUARIO";
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(":U_USUARIOS", OracleDbType.Varchar2).Value = user;
                command.Parameters.Add(":U_PASS", OracleDbType.Varchar2).Value = pass;
                command.Parameters.Add("U_CURSOR", OracleDbType.RefCursor).Direction = ParameterDirection.Output;
                using (var reader = command.ExecuteReader())
                {

                    reader.Read();
                    return Mapear(reader);

                }
            }
        }



        public usuario Mapear(OracleDataReader reader)
        {
            var usuario = new usuario();
            usuario.user = Convert.ToString(reader["USUARIOS"]);
            usuario.password = Convert.ToString(reader["PASS"]);

            return usuario;


        }

    }
}
