﻿using System;
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
        {   // cadena de conexión principal
            // cadenaconexion = "Server=100.101.219.129;DataBase= SupportHub;User Id=SupportHub;Password=SupportHub2024";
           

            // cadana conexión local Isai
            cadenaconexion = "Server=SOPORT-IT;DataBase= SupportHub;User Id=sa;Password=Isai091995";



        }

        public SqlConnection GetConnection() 
        {
            return new SqlConnection(cadenaconexion);
        }

    }
}
