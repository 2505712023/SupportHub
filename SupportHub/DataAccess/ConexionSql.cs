using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public  class ConexionSql 
    {
        private readonly string cadenaconexion;
    
        public ConexionSql()
        {   // Cadena de conexión principal
            cadenaconexion = "Server=100.101.219.129;DataBase= SupportHub;User Id=SupportHub;Password=SupportHub2024";

            //Servidor Azure
            //cadenaconexion = "Server=100.101.250.168;DataBase= SupportHub;User Id=SupportHub;Password=SupportHub2024";
        }
        public SqlConnection GetConnection() 
        {
            return new SqlConnection(cadenaconexion);
        }

    }
}
