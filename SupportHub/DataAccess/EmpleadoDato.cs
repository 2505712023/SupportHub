using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace DataAccess
{
    public class EmpleadoDato
    {
        private ConexionSql conexion =new ConexionSql();
        SqlDataReader leer;
        DataTable tabla =new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable obtenerEmpleado() {
            string nombreProcedimiento = "sp_obtener_empleados_general";

            using (SqlConnection conn = conexion.GetConnection())
            {
                cmd.CommandText = nombreProcedimiento;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                conn.Open();

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(tabla);

                return tabla;
            }
        }
        public DataTable ObtenerAreas()
        {
            string querySelect = "SELECT nombreArea FROM Areas";
            using (SqlConnection conn = conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(querySelect, conn);
                SqlDataReader lector = cmd.ExecuteReader();

                DataTable tablaAreas = new DataTable();
                tablaAreas.Load(lector);

                return tablaAreas;
            }
        }

        public DataTable ObtenerCargo()
        {
            string querySelect = "select nombreCargo from Cargos";
            using (SqlConnection conn = conexion.GetConnection())
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(querySelect, conn);
                SqlDataReader lector = cmd.ExecuteReader();

                DataTable tablaAreas = new DataTable();
                tablaAreas.Load(lector);

                return tablaAreas;
            }
        }
        public void EliminarEmpleado(string codEmp)
        {
            string nombreProcedimiento = "sp_eliminar_empleado";

            using (var comando = new SqlCommand())
            {
                comando.CommandText = nombreProcedimiento;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codEmpleado", codEmp);
                using (SqlConnection conn = conexion.GetConnection())
                {
                    comando.Connection = conn;
                    conn.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }
    }
}

