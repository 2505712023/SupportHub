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
  
    }
}
