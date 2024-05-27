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
        private ConexionSql conexion = new ConexionSql();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable obtenerEmpleado()
        {
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
            string querySelect = "SELECT * FROM Areas";
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

        public DataTable ObtenerCargos()
        {
            string querySelect = "select * from Cargos";
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

        public void InsertarEmpleado(string nombreEmpleado, string apellidoEmpleado, string telefono, string email, int idCargo, int idArea)
        {
            using (SqlConnection conn = conexion.GetConnection())
            {
                using (SqlCommand comando = new SqlCommand("sp_crear_empleado", conn))
                {
                    comando.CommandType = CommandType.StoredProcedure;
                    comando.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);
                    comando.Parameters.AddWithValue("@apellidoEmpleado", apellidoEmpleado);
                    comando.Parameters.AddWithValue("@telefonoEmpleado", telefono);
                    comando.Parameters.AddWithValue("@emailEmpleado", email);
                    comando.Parameters.AddWithValue("@IdCargo", idCargo);
                    comando.Parameters.AddWithValue("@IdArea", idArea);
                    conn.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarEmpleado(string codEmpleado, string nombreEmpleado, string apellidoEmpleado, string telefono, string email, int idCargo, int idArea)
        {
            string nombreProcedimiento = "sp_modificar_empleado";

            using (var comando = new SqlCommand())
            {
                comando.CommandText = nombreProcedimiento;
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@codEmpleado", codEmpleado);
                comando.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);
                comando.Parameters.AddWithValue("@apellidoEmpleado", apellidoEmpleado);
                comando.Parameters.AddWithValue("@telefono", telefono);
                comando.Parameters.AddWithValue("@emailEmpleado", email);
                comando.Parameters.AddWithValue("@idCargo", idCargo);
                comando.Parameters.AddWithValue("@idArea", idArea);

                using (SqlConnection conn = conexion.GetConnection())
                {
                    comando.Connection = conn;
                    conn.Open();
                    comando.ExecuteNonQuery();
                }
            }
        }

        public  DataTable filtrarTablaEmpleado(string codEmpleado = "-1", string nombreEmpleado = "-1", string apellidoEmpleado = "-1")
        { 
            using (SqlConnection conn = conexion.GetConnection())
            {
                cmd.CommandText = "sp_obtener_empleado";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@codEmpleado" , codEmpleado);
                cmd.Parameters.AddWithValue("@nombreEmpleado", nombreEmpleado);
                cmd.Parameters.AddWithValue("@apellidoEmpleado", apellidoEmpleado);
                cmd.Connection = conn;

                conn.Open();

                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                tabla.Clear();
                adaptador.Fill(tabla);

                return tabla;
            }
        }
    }
}
