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
using System.Runtime.CompilerServices;
using System.Diagnostics;

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
                                    int idRol = reader.GetInt32(reader.GetOrdinal("idRol"));
                                    string nombreRol = reader.GetString(reader.GetOrdinal("nombreRol"));
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
        //Hecho por KEVIN 
        private DataTable tabla = new DataTable();
        public DataTable obtenerUsuario()
        {
            string nombreProcedimiento = "sp_obtener_usuarios";

            using (var conexion = GetConnection())
            {

                using (var comando = new SqlCommand())
                {
                    comando.CommandText = nombreProcedimiento;
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Connection = conexion;

                    conexion.Open();

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    adaptador.Fill(tabla);
                }
                return tabla;
            }
        }

        public bool ValidarLogin(string login)
        {
            bool existe = false;
            string query = "SELECT COUNT(1) FROM Usuarios WHERE LoginUsuario = @Login";

            using (var conexion = GetConnection())
            {
                SqlCommand command = new SqlCommand(query, conexion);
                command.Parameters.AddWithValue("@Login", login);

                try
                {
                    conexion.Open();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        existe = true;
                    }
                }
                catch (Exception ex)
                {
            
                    throw new Exception("Error checking login existence", ex);
                }
                
            }

            return existe;
        }


        public DataTable filtrarTablaUsuario(string loginUsuario = "-1", string nombresUsuario = "-1", string apellidosUsuario = "-1")
        {
            using (var conexion = GetConnection())
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.CommandText = "sp_obtener_busqueda_Usuario";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@loginUsuario", loginUsuario);
                    cmd.Parameters.AddWithValue("@nombresUsuario", nombresUsuario);
                    cmd.Parameters.AddWithValue("@apellidosUsuario", apellidosUsuario);
                    cmd.Connection = conexion;

                    conexion.Open();

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    tabla.Clear();
                    adaptador.Fill(tabla);
                }
                return tabla;
            }
        }

        public DataTable ObtenerEmpleados(int? idEmpleado)
        {
            string querySelect = "sp_obtener_empleados_sin_usuario";
            using (var conexion = GetConnection())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(querySelect, conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                SqlDataReader lector = cmd.ExecuteReader();

                DataTable tablaEmpleado = new DataTable();
                tablaEmpleado.Load(lector);

                return tablaEmpleado;
            }
        }

        public string ObtenerNombreEmpleado(int idEmpleado)
        {
            string query = $"select nombreEmpleado from empleados where idEmpleado = '{idEmpleado}'";
            string nombre = string.Empty;
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new(query, conn);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    nombre = lector.GetString(0);
                }
                return nombre;
            }
        }

        public string ObtenerApellidoEmpleado(int idEmpleado)
        {
            string query = $"select apellidoEmpleado from empleados where idEmpleado = '{idEmpleado}'";
            string apellido = string.Empty;
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new(query, conn);
                SqlDataReader lector = cmd.ExecuteReader();
                while (lector.Read())
                {
                    apellido = lector.GetString(0);
                }
                return apellido;
            }
        }

        public DataTable ObtenerRoles()
        {
            string query = "sp_obtener_roles";
            using (var conexion = GetConnection())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(query, conexion);
                SqlDataAdapter adaptador = new(cmd);
                DataTable tablaRoles = new DataTable();

                adaptador.Fill(tablaRoles) ;

                return tablaRoles;
            }
        }

        public void ActualizarUsuario(string LoginUsuario, string nombreUsuario, string apellidoUsuario, string contrasenia, int activo, string tipousuario)
        {
            string query_usuario = "sp_modificar_usuario";
            string query_usuario_rol = "sp_modificar_usuarioxrol";

            using (var conexion = GetConnection())
            {
                conexion.Open();

                using (var comando = new SqlCommand(query_usuario, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@loginUsuario", LoginUsuario);
                    comando.Parameters.AddWithValue("@nombresUsuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@apellidosUsuario", apellidoUsuario);
                    comando.Parameters.AddWithValue("@contrasenia", contrasenia);

                    comando.ExecuteNonQuery();
                }
             
                using (var comando = new SqlCommand(query_usuario_rol, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@LoginUsuario", LoginUsuario);
                    comando.Parameters.AddWithValue("@tipousuario", tipousuario);

                    comando.ExecuteNonQuery();
                }
            }
        }

        public void EliminarUsuario(string loginUsuario)
        {
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                string query = "sp_borrar_usuario";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@loginUsuario", loginUsuario);
                cmd.ExecuteNonQuery();
            }
        }

        public void InsertarUsuario(string LoginUsuario,string NombreUsuario,string ApellidoUsuario,string Contrasenia,int ActivoUsuario,int idEmpleado)
        {
            using (var conexion = GetConnection())
            {
                using (SqlCommand comando = new SqlCommand("sp_crear_usuario", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@loginusuario", LoginUsuario);
                    comando.Parameters.AddWithValue("@nombresUsuario", NombreUsuario);
                    comando.Parameters.AddWithValue("@apellidosUsuario", ApellidoUsuario);
                    comando.Parameters.AddWithValue("@claveUsuario", Contrasenia);
                    comando.Parameters.AddWithValue("@activoUsuario", ActivoUsuario);
                    comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public int ObtenerIdUsuario(string loginUsuario)
        {
            using (var conexion = GetConnection())
            {
                conexion.Open();
                string query = $"SELECT idUsuario FROM Usuarios where loginUsuario = '{loginUsuario}'";
                SqlCommand command = new SqlCommand(query, conexion);
                SqlDataReader reader = command.ExecuteReader();

                int id = 0;
                while (reader.Read())
                {
                    id = reader.GetInt32(0);
                }

                return id;
            }
        }
        
        public void InsertarUsuarioxRol(int idRol, string loginUsuario)
        {
            int idUsuario = ObtenerIdUsuario(loginUsuario);
            using (var conexion = GetConnection())
            {
                using (SqlCommand comando = new SqlCommand("sp_crear_usuarioxrol", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                    comando.Parameters.AddWithValue("@idRol", idRol);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public bool ValidarRolActivoXUsuario(string loginUsuario, int idRol)
        {
            string query = "sp_verificar_rol_activo_usuario";
            using (SqlConnection conn = GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@loginUsuario", loginUsuario);
                cmd.Parameters.AddWithValue("@idRol", idRol);
                SqlDataReader lector = cmd.ExecuteReader();
                
                bool resultado = false;
                while (lector.Read())
                {
                    resultado = lector.GetBoolean(0);
                }

                return resultado;
            }
        }
    }
}
