using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ModeloEntrega
    {
        public static DataTable mostrarEntregas()
        {
            return EntregaDato.obtenerTablaEntregas();
        }

        public static DataTable filtrarTablaEntregas(
            string codEntrega = "-1",
            string nombreTipoEntrega = "-1",
            string nombreTipoEquipo = "-1",
            string modeloEquipo = "-1",
            string marcaEquipo = "-1",
            string empleadoEntrega = "-1",
            string observacionEntrega = "-1")
        {
            return EntregaDato.filtrarTablaEntregas(
                codEntrega, 
                nombreTipoEntrega, 
                nombreTipoEquipo, 
                modeloEquipo, 
                marcaEquipo,
                empleadoEntrega,
                observacionEntrega);
        }

        public static int eliminarEntrega(string? codEntrega)
        {
            return EntregaDato.eliminarEntrega(codEntrega);
        }

        public static DataTable obtenerEmpleados()
        {
            return EntregaDato.obtenerEmpleados();
        }

        public static DataTable obtenerEquipos()
        {
            return EntregaDato.obtenerEquipos();
        }
        public static int cantidadDisponibleEquipo(int idEquipo)
        {
            return EntregaDato.cantidadDisponibleEquipo(idEquipo);
        }
        public static DataTable obtenerTiposEntrega()
        {
            return EntregaDato.obtenerTiposEntrega();
        }
    }
}
