using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess
{
    public abstract class ConexionSql
    {
        private readonly string cadenaconexion;
        public ConexionSql() {
            cadenaconexion = "Server=SOPORT-IT;DataBase= SupportHub;User Id=SupportHub;Password=SupportHub2024";        
       }
        protected SqlConnection GetConnection() {
            return new SqlConnection (cadenaconexion);
        }



    }
}
