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

        public static DataTable filtrarTablaEntregasPorCodigo(string codEntrega)
        {
            using (SqlConnection conect = conexion.GetConnection())
            {
                comando.CommandText = "sp_obtener_entrega";
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@codEntrega", codEntrega);
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
