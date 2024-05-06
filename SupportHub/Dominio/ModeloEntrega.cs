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
            string empleadoRecibe = "-1",
            string observacionEntrega = "-1")
        {
            return EntregaDato.filtrarTablaEntregas(
                codEntrega, 
                nombreTipoEntrega, 
                nombreTipoEquipo, 
                modeloEquipo, 
                marcaEquipo,
                empleadoEntrega,
                empleadoRecibe,
                observacionEntrega);
        }

        public static int crearEntrega(int idTipoEntrega, string fechaEntrega, int idEmpleadoEntrega, int idEmpleadoRecibe, int idEquipo, int cantidadEntrega, string? observacionEntrega)
        {
            return EntregaDato.crearEntrega(idTipoEntrega, fechaEntrega, idEmpleadoEntrega, idEmpleadoRecibe, idEquipo, cantidadEntrega, observacionEntrega);
        }

        public static int modificarEntrega(string codEntrega, int idTipoEntrega, string fechaEntrega, int idEmpleadoRecibe, int idEquipo, int cantidadEntrega, string? observacionEntrega)
        {
            return EntregaDato.modificarEntrega(codEntrega, idTipoEntrega, fechaEntrega, idEmpleadoRecibe, idEquipo, cantidadEntrega, observacionEntrega);
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
        public static string asignarFechaDevolucion(string fechaDevolucion, string codEntrega)
        {
            return EntregaDato.asignarFechaDevolucion(fechaDevolucion, codEntrega);
        }
    }
}
