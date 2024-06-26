﻿using System;
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

        public DataTable ObtenerArea()
        {
            return empDato.ObtenerAreas();
        }

        public DataTable ObtenerCargo()
        {
            return empDato.ObtenerCargos();
        }

        public void EliminarEmp(string codEmp)
        {
            empDato.EliminarEmpleado(codEmp); 
        }

        public void InsertarEmpleado(string nombreEmpleado, string apellidoEmpleado, string telefono, string email, int idCargo, int idArea)
        {
            empDato.InsertarEmpleado(nombreEmpleado, apellidoEmpleado, telefono, email, idCargo, idArea);
        }

        public void ActualizarEmpleado(string codEmpleado, string nombreEmpleado, string apellidoEmpleado, string telefono, string email, int idCargo, int idArea)
        {
            empDato.ActualizarEmpleado(codEmpleado, nombreEmpleado, apellidoEmpleado, telefono, email, idCargo, idArea);
        }

        public  DataTable filtrarTablaEmpleado(string codEmpleado = "-1", string nombreEmpleado = "-1", string apellidoEmpleado = "-1")
        {
            return empDato.filtrarTablaEmpleado(codEmpleado, nombreEmpleado, apellidoEmpleado);
        }
    }
}
