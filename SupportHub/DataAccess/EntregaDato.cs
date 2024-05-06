using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class EntregaDato
    {
        private static ConexionSql conexion = new ConexionSql();
        private static DataTable tabla = new DataTable();
        private static SqlCommand comando = new SqlCommand();

        public static DataTable obtenerTablaEntregas()
        {
            using (SqlConnection conect = conexion.GetConnection())
            {
                comando.CommandText = "sp_obtener_entregas";
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

        public static DataTable filtrarTablaEntregas(
            string codEntrega = "-1",
            string nombreTipoEntrega = "-1",
            string nombreTipoEquipo = "-1",
            string modeloEquipo = "-1",
            string marcaEquipo = "-1",
            string empleadoEntrega = "-1",
            string empleadoRecibe = "-1",
            string observacionEntrega = "-1")
        {
            using (SqlConnection conect = conexion.GetConnection())
            {
                comando.CommandText = "sp_obtener_entregas_filtradas";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codEntrega", codEntrega);
                comando.Parameters.AddWithValue("@nombreTipoEntrega", nombreTipoEntrega);
                comando.Parameters.AddWithValue("@nombreTipoEquipo", nombreTipoEquipo);
                comando.Parameters.AddWithValue("@modeloEquipo", modeloEquipo);
                comando.Parameters.AddWithValue("@marcaEquipo", marcaEquipo);
                comando.Parameters.AddWithValue("@empleadoEntrega", empleadoEntrega);
                comando.Parameters.AddWithValue("@empleadoRecibe", empleadoRecibe);
                comando.Parameters.AddWithValue("@observacionEntrega", observacionEntrega);
                comando.Connection = conect;

                conect.Open();
                
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                tabla.Clear();
                adaptador.Fill(tabla);

                return tabla;
            }
        }

        public static int crearEntrega(int idTipoEntrega, string fechaEntrega, int idEmpleadoEntrega, int idEmpleadoRecibe, int idEquipo, int cantidadEntrega, string? observacionEntrega)
        {
            using (SqlConnection conect = conexion.GetConnection())
            {
                comando.CommandText = "sp_crear_entrega";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@idTipoEntrega", idTipoEntrega);
                comando.Parameters.AddWithValue("@fechaEntrega", fechaEntrega);
                comando.Parameters.AddWithValue("@idEmpleadoEntrega", idEmpleadoEntrega);
                comando.Parameters.AddWithValue("@idEmpleadoRecibe", idEmpleadoRecibe);
                comando.Parameters.AddWithValue("@idEquipo", idEquipo);
                comando.Parameters.AddWithValue("@cantidadEntrega", cantidadEntrega);
                comando.Parameters.AddWithValue("@observacionEntrega", observacionEntrega);
                comando.Connection = conect;

                conect.Open();

                int numRegistrosAgregados = comando.ExecuteNonQuery();

                return numRegistrosAgregados;
            }
        }

        public static int eliminarEntrega(string? codEntrega)
        {
            using (SqlConnection conect = conexion.GetConnection())
            {
                comando.CommandText = "sp_eliminar_entrega";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codEntrega", codEntrega);
                comando.Connection = conect;

                conect.Open();

                int numRegistrosEliminados = comando.ExecuteNonQuery();
                
                return numRegistrosEliminados;
            }
        }

        public static DataTable obtenerEmpleados()
        {
            string querySelectEmpleados = "select idEmpleado as [idEmpleado],nombreEmpleado + ' ' + apellidoEmpleado + ' - ' + codEmpleado as [Empleado] from Empleados";

            using (SqlConnection conect = conexion.GetConnection())
            {
                conect.Open();
                SqlCommand comando = new SqlCommand(querySelectEmpleados, conect);
                SqlDataReader lector = comando.ExecuteReader();

                DataTable tablaEmpleados = new DataTable();
                tablaEmpleados.Load(lector);

                return tablaEmpleados;
            }
        }

        public static DataTable obtenerEquipos()
        {
            string querySelectEquipos = "select idEquipo as [idEquipo],trim(tipoEquipo) + ' - ' + trim(marcaEquipo) + ' - ' + trim(modeloEquipo) as [Equipo] from Equipos";

            using (SqlConnection conect = conexion.GetConnection())
            {
                conect.Open();
                SqlCommand comando = new SqlCommand(querySelectEquipos, conect);
                SqlDataReader lector = comando.ExecuteReader();

                DataTable tablaEquipos = new DataTable();
                tablaEquipos.Load(lector);

                return tablaEquipos;
            }
        }

        public static int cantidadDisponibleEquipo(int idEquipo)
        {
            string querySelectCantidadDisponibleEquipo = "select * from vwCantidadEquiposDisponibles E where E.idEquipo = " + idEquipo.ToString();
            int cantidadDisponible = 0;

            using (SqlConnection conect = conexion.GetConnection())
            {
                conect.Open();
                SqlCommand comando = new SqlCommand(querySelectCantidadDisponibleEquipo, conect);
                SqlDataReader lector = comando.ExecuteReader();

                if (lector.Read())
                {
                    cantidadDisponible = Convert.ToInt32(lector.GetValue("cantidadDisponible"));
                }
            }

            return cantidadDisponible;
        }

        public static DataTable obtenerTiposEntrega()
        {
            string querySelectTiposEntrega = "select idTipoEntrega, nombreTipoEntrega from TiposEntregas";

            using (SqlConnection conect = conexion.GetConnection())
            {
                conect.Open();
                SqlCommand comando = new SqlCommand(querySelectTiposEntrega, conect);
                SqlDataReader lector = comando.ExecuteReader();

                DataTable tablaTiposEntrega = new DataTable();
                tablaTiposEntrega.Load(lector);

                return tablaTiposEntrega;
            }
        }

        public static string asignarFechaDevolucion(string fechaDevolucion, string codEntrega)
        {
            string queryUpdateEntrega = string.Empty;

            if (fechaDevolucion == "ELIMINAR")
            {
                queryUpdateEntrega = "update entregas set fechaDevolucion = null where codEntrega = '" + codEntrega + "'";
            }
            else
            {
                queryUpdateEntrega = "update entregas set fechaDevolucion = '" + fechaDevolucion + "' where codEntrega = '" + codEntrega + "'";
            }
            
            using (SqlConnection conect = conexion.GetConnection())
            {
                conect.Open();
                SqlCommand comando = new SqlCommand(queryUpdateEntrega, conect);
                
                comando.ExecuteNonQuery();
            }

            return "Fecha de devolución asignada exitosamente.";
        }
    }
}
