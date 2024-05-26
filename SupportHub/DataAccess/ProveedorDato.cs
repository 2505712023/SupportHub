using System.Data.SqlClient;
using System.Data;

namespace DataAccess
{
    public class ProveedorDato
    {
        private ConexionSql conexion = new();
        DataTable tabla = new();
        SqlCommand cmd = new();

        public DataTable ObtenerProveedores()
        {
            string nombreProcedimiento = "sp_obtener_proveedores_general";

            using SqlConnection conn = conexion.GetConnection();

            cmd.CommandText = nombreProcedimiento;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = conn;

            conn.Open();

            SqlDataAdapter adaptador = new(cmd);
            adaptador.Fill(tabla);
            conn.Close();

            return tabla;
        }

        public void AgregarProveedor(string codProveedor, string nombreProveedor, string direccion, string telefono)
        {
            using SqlConnection conn = conexion.GetConnection();

            using SqlCommand cmd = new("sp_crear_proveedor", conn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@codProveedor", codProveedor);
            cmd.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);
            cmd.Parameters.AddWithValue("@direccionProveedor", direccion);
            cmd.Parameters.AddWithValue("@telefonoProveedor", telefono);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ActualizarProveedor(int idProveedor, string codProveedor, string nombreProveedor, string direccion, string telefono)
        {
            using SqlConnection conn = conexion.GetConnection();

            using SqlCommand comando = new("sp_modificar_proveedor", conn);
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@codProveedor", codProveedor);
            comando.Parameters.AddWithValue("@idProveedor", idProveedor);
            comando.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);
            comando.Parameters.AddWithValue("@direccionProveedor", direccion);
            comando.Parameters.AddWithValue("@telefonoProveedor", telefono);
            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public void EliminarEmpleado(int idProveedor)
        {
            using SqlConnection conn = conexion.GetConnection();

            using SqlCommand comando = new("sp_eliminar_proveedor", conn);

            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProveedor", idProveedor);

            comando.Connection = conn;
            conn.Open();
            comando.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable ObtenerProveedor(string codProveedor = "-1", string nombreProveedor = "-1")
        {
            using SqlConnection conn = conexion.GetConnection();

            cmd.CommandText = "sp_obtener_proveedor";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nombreProveedor", nombreProveedor);
            cmd.Parameters.AddWithValue("@codProveedor", codProveedor);
            cmd.Connection = conn;

            conn.Open();

            SqlDataAdapter adaptador = new(cmd);
            tabla.Clear();
            adaptador.Fill(tabla);

            conn.Close();

            return tabla;
        }
    }
}
