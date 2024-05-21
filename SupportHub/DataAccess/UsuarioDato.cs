using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Comun.Cache;
using System.Reflection.Metadata;
using System.Collections;
namespace DataAccess
{
    public class UsuarioDato : ConexionSql
    {
        public void ModificarContraseña(int idUsuario, string nuevaContraseña)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                using (var comando = new SqlCommand("sp_modificar_contraseña", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@claveUsuario", nuevaContraseña);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public string Login(string user, string pass)

        {
           
            try
            {
                using (var connection = GetConnection())
                {
                    connection.Open();
                    using (var command = new SqlCommand())
                    {
                        command.Connection = connection;
                        command.CommandText = "sp_autenticar_usuario";
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@LoginName", user);
                        command.Parameters.AddWithValue("@Password", pass);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    bool activoUsuario = reader.GetBoolean(reader.GetOrdinal("activoUsuario"));
                                    if (!activoUsuario)
                                    {
                                        return "El usuario está inactivo";
                                    }

                                    // Extracción y asignación de otros campos
                                    CacheInicioUsuario.IdUser = reader.GetInt32(reader.GetOrdinal("idUsuario"));
                                    CacheInicioUsuario.password = reader.GetString(reader.GetOrdinal("claveUsuario"));
                                    CacheInicioUsuario.user = reader.GetString(reader.GetOrdinal("loginUsuario"));
                                    CacheInicioUsuario.nombreUser = reader.GetString(reader.GetOrdinal("nombreUsuario"));
                                    CacheInicioUsuario.apellidoUser = reader.GetString(reader.GetOrdinal("apellidoUsuario"));
                                    CacheInicioUsuario.rolUser = reader.GetString(reader.GetOrdinal("nombreRol"));
                                    CacheInicioUsuario.empleado = reader.GetString(reader.GetOrdinal("Empleado"));
                                    CacheInicioUsuario.idEmpleado = reader.GetInt32(reader.GetOrdinal("idEmpleado"));
                                }
                                reader.Close();

                                // Obtener permisos del usuario
                                using (var commandPermisos = new SqlCommand())
                                {
                                    commandPermisos.Connection = connection;
                                    commandPermisos.CommandText = "select p.nombrePermiso " +
                                                                  "from PermisosXRoles pr " +
                                                                  "inner join Permisos p on p.idPermiso = pr.idPermiso " +
                                                                  "inner join Roles r on r.idRol = pr.idRol " +
                                                                  "where r.nombreRol = @NombreRol";
                                    commandPermisos.Parameters.AddWithValue("@NombreRol", CacheInicioUsuario.rolUser);
                                    commandPermisos.CommandType = CommandType.Text;

                                    using (SqlDataReader readerPermisos = commandPermisos.ExecuteReader())
                                    {
                                        CacheInicioUsuario.permisosUser = new ArrayList();
                                        while (readerPermisos.Read())
                                        {
                                            CacheInicioUsuario.permisosUser.Add(readerPermisos.GetString(readerPermisos.GetOrdinal("nombrePermiso")));
                                        }
                                    }
                                }
                                return "Inicio de sesión exitoso";
                            }
                            else
                            {
                                return "Usuario o contraseña incorrecto";
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                return "Error de conexión: " + ex.Message;
            }
            catch (Exception ex)
            {
                return "Error durante el inicio de sesión: " + ex.Message;
            }
        }
        }
}