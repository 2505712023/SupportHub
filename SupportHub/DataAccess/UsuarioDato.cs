using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Comun.Cache;
namespace DataAccess
{
    public class UsuarioDato : ConexionSql
    {
        public bool Login(string user, string pass)
        {
            using (var coneccion = GetConnection())
            {
                coneccion.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = coneccion;
                    comando.CommandText = "sp_AutenticarUsuario";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@LoginName", user);
                    comando.Parameters.AddWithValue("@Password", pass);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                // Leer los datos del usuario
                                int idUsuario = reader.GetInt32(reader.GetOrdinal("idUsuario"));
                                string claveUsuario = reader.GetString(reader.GetOrdinal("claveUsuario"));
                                string loginUsuario = reader.GetString(reader.GetOrdinal("loginUsuario"));
                                string nombreUsuario = reader.GetString(reader.GetOrdinal("nombreUsuario"));
                                string apellidoUsuario = reader.GetString(reader.GetOrdinal("apellidoUsuario"));

                 
                                int idRol = reader.GetInt32(reader.GetOrdinal("idRol"));
                                string nombreRol = reader.GetString(reader.GetOrdinal("nombreRol"));
                                CacheInicioUsuario.nombreUser = reader.GetString(3);
                                CacheInicioUsuario.apellidoUser = reader.GetString(4);

                            }
                            return true; 
                        }
                        else
                        {

                            return false;
                        }

                    }
                }
            }
        }
    }
}