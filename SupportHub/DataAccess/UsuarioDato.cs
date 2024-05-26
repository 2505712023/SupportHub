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


        public DataTable filtrarTablaUsuario(string loginUsuario = "-1", string nombreUsuario = "-1", string apellidoUsuario = "-1")
        {

            using (var conexion = GetConnection())
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.CommandText = "SP_obtener_busqueda_Usuario";
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@nombrelogiUsuario", loginUsuario);
                    cmd.Parameters.AddWithValue("@nombreusuario", nombreUsuario);
                    cmd.Parameters.AddWithValue("@apellidousuario", apellidoUsuario);
                    cmd.Connection = conexion;

                    conexion.Open();

                    SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                    tabla.Clear();
                    adaptador.Fill(tabla);
                }


                return tabla;
            }
        }

        public DataTable ObtenerNombres()
        {
            string querySelect = "SELECT * frOM Empleados";
            using (var conexion = GetConnection())
            {
                
                conexion.Open();
                SqlCommand cmd = new SqlCommand(querySelect, conexion);
                SqlDataReader lector = cmd.ExecuteReader();

                DataTable tablaempleado = new DataTable();
                tablaempleado.Load(lector);

                return tablaempleado;
               

            }
               
        }
        public DataTable ObtenerApellidos()
        {
            string querySelect = "SELECT apellidoempleado frOM Empleados";
            using (var conexion = GetConnection())
            {

                conexion.Open();
                SqlCommand cmd = new SqlCommand(querySelect, conexion);
                SqlDataReader lector = cmd.ExecuteReader();

                DataTable tablaempleado = new DataTable();
                tablaempleado.Load(lector);

                return tablaempleado;


            }

        }

        public DataTable ObtenerRoles()
        {
            string querySelect = "select nombreRol from Roles";
            using (var conexion = GetConnection())
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand(querySelect, conexion);
                SqlDataReader lector = cmd.ExecuteReader();

                DataTable tablaAreas = new DataTable();
                tablaAreas.Load(lector);

                return tablaAreas;
            }
        }

        public void ActualizarUsuario(string LoginUsuario, string nombreUsuario, string apellidoUsuario, string contrasenia, int activo, string tipousuario)
        {
            string nombreProcedimiento1 = "sp_modificar_usuario";
            string nombreProcedimiento2 = "sp_modificar_usuarioxrol";

            using (var conexion = GetConnection())
            {
                conexion.Open();


                using (var comando = new SqlCommand(nombreProcedimiento1, conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@LoginUsuario", LoginUsuario);
                    comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    comando.Parameters.AddWithValue("@apellidoUsuario", apellidoUsuario);
                    comando.Parameters.AddWithValue("@contrasenia", contrasenia);

                    comando.ExecuteNonQuery();
                }

             
                using (var comando = new SqlCommand(nombreProcedimiento2, conexion))
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
                    comando.Parameters.AddWithValue("@nombreusuario", NombreUsuario);
                    comando.Parameters.AddWithValue("@apellidousuario", ApellidoUsuario);
                    comando.Parameters.AddWithValue("@claveusuario", Contrasenia);
                    comando.Parameters.AddWithValue("@activousuario", ActivoUsuario);
                    comando.Parameters.AddWithValue("@idEmpleado", idEmpleado);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }



        public int ObtenerUltimoId()
        {
            using (var conexion=GetConnection())
            {
                conexion.Open();
                string query = "SELECT TOP 1 IdUsuario FROM Usuarios ORDER BY IdUsuario DESC";
;
                SqlCommand command = new SqlCommand(query, conexion);
                int id= (int)command.ExecuteScalar();
                return id;
            }
        }
        
        public void InsertarUsuarioxRol(int IdRol)
        {
           int IdUsuario = ObtenerUltimoId();
            using (var conexion = GetConnection())
            {
                using (SqlCommand comando = new SqlCommand("sp_crear_usuarioxrol", conexion))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@idUsuario", IdUsuario);
                    comando.Parameters.AddWithValue("@idRol", IdRol);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}
