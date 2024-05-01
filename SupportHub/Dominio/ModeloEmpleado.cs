using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataAccess;
using System.Data;
namespace Dominio
{
    public class ModeloEmpleado
    {
        private EmpleadoDato empDato = new EmpleadoDato();

        public DataTable mostrarEmpleado() { 
        DataTable tabla = new DataTable();
            tabla= empDato.obtenerEmpleado();
            return tabla;
        
        }

        public DataTable ObtenerAreas()
        {
            return empDato.ObtenerAreas();
        }

        public DataTable ObtenerCargos()
        {
            return empDato.ObtenerCargo();
        }
    }


   

}
