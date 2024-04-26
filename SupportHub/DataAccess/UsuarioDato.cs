using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
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

                                // Leer los datos del rol
                                int idRol = reader.GetInt32(reader.GetOrdinal("idRol"));
                                string nombreRol = reader.GetString(reader.GetOrdinal("nombreRol"));

                                // Aquí podrías manejar los datos del usuario y del rol como desees
                                // Por ejemplo, podrías asignarlos a una clase de usuario personalizada y manejar los roles asociados al usuario



                                // Podrías hacer algo más con los datos, como asignar roles, permisos, etc.
                            }
                            return true; // Autenticación exitosa
                        }
                        else
                        {

                            return false; // Usuario y/o contraseña incorrectos
                        }

                    }
                }
            }
        }
    }
}