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
            string observacionEntrega = "-1")
        {
            using (SqlConnection conect = conexion.GetConnection())
            {
                comando.CommandText = "sp_obtener_entrega";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codEntrega", codEntrega);
                comando.Parameters.AddWithValue("@nombreTipoEntrega", nombreTipoEntrega);
                comando.Parameters.AddWithValue("@nombreTipoEquipo", nombreTipoEquipo);
                comando.Parameters.AddWithValue("@modeloEquipo", modeloEquipo);
                comando.Parameters.AddWithValue("@marcaEquipo", marcaEquipo);
                comando.Parameters.AddWithValue("@empleado", empleadoEntrega);
                comando.Parameters.AddWithValue("@observacionEntrega", observacionEntrega);
                comando.Connection = conect;

                conect.Open();
                
                SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                tabla.Clear();
                adaptador.Fill(tabla);

                return tabla;
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
            string querySelectEmpleados = "select idEmpleado as [idEmpleado],nombreEmpleado + ' ' + apellidosEmpleados as [Empleado] from Empleados";

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
            string querySelectEquipos = "select idEquipo as [idEquipo],trim(tipoEquipo) + ' - ' + trim(modeloEquipo) + ' - ' + trim(marcaEquipo) as [Equipo] from Equipos";

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
    }
}
