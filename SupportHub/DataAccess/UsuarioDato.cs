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
                using (var coneccion = GetConnection())
                {
                    coneccion.Open();
                    using (var comando = new SqlCommand())
                    {
                        comando.Connection = coneccion;
                        comando.CommandText = "sp_autenticar_usuario";
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
                                    CacheInicioUsuario.IdUser = reader.GetInt32(0);
                                    CacheInicioUsuario.password = reader.GetString(1);
                                    CacheInicioUsuario.user=reader.GetString(2);
                                    CacheInicioUsuario.nombreUser = reader.GetString(3);
                                    CacheInicioUsuario.apellidoUser = reader.GetString(4);
                                    CacheInicioUsuario.rolUser = reader.GetString(reader.GetOrdinal("nombreRol"));
                                    CacheInicioUsuario.empleado = reader.GetString(reader.GetOrdinal("Empleado"));
                                    CacheInicioUsuario.idEmpleado = reader.GetInt32(reader.GetOrdinal("idEmpleado"));
                                }
                                reader.Close();

                                using (var comandoPermisos = new SqlCommand())
                                {
                                    comandoPermisos.Connection = coneccion;
                                    comandoPermisos.CommandText = "select p.nombrePermiso " +
                                                                    "from PermisosXRoles pr " +
                                                                    "inner join Permisos p on p.idPermiso = pr.idPermiso " +
                                                                    "inner join Roles r on r.idRol = pr.idRol " +
                                                                    "where r.nombreRol = '" + CacheInicioUsuario.rolUser + "'";
                                    comandoPermisos.CommandType = CommandType.Text;

                                    using (SqlDataReader readerPermisos = comandoPermisos.ExecuteReader())
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
                using (var comando=new SqlCommand())
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

        public DataTable filtrarTablaUsuario(string idUsuario = "-1")
        {

            using (var conexion = GetConnection())
            {
                using (var comando = new SqlCommand())
                {
                    comando.CommandText = "sp_obtener_usuario";
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("@idUsuario", idUsuario);
                   
                    comando.Connection = conexion;

                    conexion.Open();

                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    tabla.Clear();
                    adaptador.Fill(tabla);
                }

                return tabla;
            }
        }








    }
}
