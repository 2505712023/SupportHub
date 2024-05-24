using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class EquipoDato
    {
        private static ConexionSql conexion = new ConexionSql();
        private static DataTable tabla = new DataTable();
        private static SqlCommand comando = new SqlCommand();

        public static DataTable obtenerTablaEquipos()
        {
            using (SqlConnection conect = conexion.GetConnection())
            {
                comando.CommandText = "sp_obtener_equipos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Connection = conect;

                conect.Open();

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                tabla.Clear();
                adaptador.Fill(tabla);

                return tabla;

            }

        }
        
        public static int EliminarEquipo (string? codEquipo)
        {
            using (SqlConnection conect = conexion.GetConnection()) { 
                comando.CommandText = "sp_borrar_equipo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codEquipo", codEquipo);
                comando.Connection = conect;
                conect.Open();
                
                int numRegistroEliminados = comando.ExecuteNonQuery();
                return numRegistroEliminados;
            }
        }
        public static int crearEquipo(string TipoEquipo, string marcaEquipo, string modeloEquipo, int cantidadEquipo,double precioEquipo, int idProveedor, string descripcionEquipo = "-1")
        {
            using (SqlConnection conect = conexion.GetConnection())
            {
                comando.CommandText = "sp_crear_equipo";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@TipoEquipo", TipoEquipo);
                comando.Parameters.AddWithValue("@marcaEquipo", marcaEquipo);
                comando.Parameters.AddWithValue("@modeloEquipo", modeloEquipo);
                comando.Parameters.AddWithValue("@cantidadEquipo", cantidadEquipo);
                comando.Parameters.AddWithValue("@precioEquipo", precioEquipo);
                comando.Parameters.AddWithValue("@idProveedor", idProveedor);
                comando.Parameters.AddWithValue("@descripcionEquipo", descripcionEquipo);
                comando.Connection = conect;

                conect.Open();

                int numRegistrosAgregados = comando.ExecuteNonQuery();

                return numRegistrosAgregados;
            }

            }
        public static DataTable obtenerProveedor()
        {
            string querySelectProveedores = "select idProveedor as [idProveedor], nombreProveedor as [Proveedor] from Proveedores";

            using (SqlConnection conect = conexion.GetConnection())
            {
                conect.Open();
                SqlCommand comando = new SqlCommand(querySelectProveedores, conect);
                SqlDataReader lector = comando.ExecuteReader();

                DataTable tablaProveedores = new DataTable();
                tablaProveedores.Load(lector);

                return tablaProveedores;
            }
        }
        
        public static DataTable filtrarTablaEquipo(
           string TipoEquipo = "-1",
           string marcaEquipo = "-1", 
           string modeloEquipo = "-1", 
           string cantidadEquipo = "-1", 
           string precioEquipo = "-1",
           string idProveedor = "-1", 
           string descripcionEquipo = "-1" )
        {
            using (SqlConnection conect = conexion.GetConnection())
            {

                comando.CommandText = "sp_obtener_equipos";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@TipoEquipo", TipoEquipo);
                comando.Parameters.AddWithValue("@marcaEquipo", marcaEquipo);
                comando.Parameters.AddWithValue("@modeloEquipo", modeloEquipo);
                comando.Parameters.AddWithValue("@cantidadEquipo", cantidadEquipo);
                comando.Parameters.AddWithValue("@precioEquipo", precioEquipo);
                comando.Parameters.AddWithValue("@idProveedor", idProveedor);
                comando.Parameters.AddWithValue("@descripcionEquipo", descripcionEquipo);
                comando.Connection = conect;

                conect.Open();

                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                tabla.Clear();
                adaptador.Fill(tabla);

                return tabla;
            }

        }
    }
    }

