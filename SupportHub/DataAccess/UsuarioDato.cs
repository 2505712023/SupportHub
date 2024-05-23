﻿using System;
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
                                    CacheInicioUsuario.user = reader.GetString(2);
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

        public DataTable ObtenerEmpleado()
        {
            string querySelect = "SELECT nombreempleado,apellidoempleado FROM Empleados";
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

            using (var comando = new SqlCommand())
            {
                comando.CommandText = nombreProcedimiento1;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@LoginUsuario", LoginUsuario);
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@apellidoUsuario", apellidoUsuario);
                comando.Parameters.AddWithValue("@claveUsuario",contrasenia );
                comando.Parameters.AddWithValue("@activo", activo);
                comando.Parameters.AddWithValue("@tipousuario", activo);

               
                comando.CommandText = nombreProcedimiento2;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idUsuarioXRol", LoginUsuario);


                using (SqlConnection conn = GetConnection())
                {
                    comando.Connection = conn;
                    conn.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }


    }



}

