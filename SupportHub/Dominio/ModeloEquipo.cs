using DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ModeloEquipo
    {
        public static DataTable obtenerTablaEquipos()
        {
            return EquipoDato.obtenerTablaEquipos();
        }
        public static int EliminarEquipo(string? codEquipo)
        {
            return EquipoDato.EliminarEquipo(codEquipo);
        }

        public static int crearEquipo(string TipoEquipo, string marcaEquipo, string modeloEquipo, int cantidadEquipo, double precioEquipo, int idProveedor, string descripcionEquipo)
        {
            return EquipoDato.crearEquipo(TipoEquipo, marcaEquipo, modeloEquipo, cantidadEquipo, precioEquipo, idProveedor, descripcionEquipo);
        }

        public static DataTable obtenerProveedor()
        {
            return EquipoDato.obtenerProveedor();
        }
        public static DataTable filtrarTablaEquipo(
          string TipoEquipo = "-1",
          string marcaEquipo = "-1",
          string modeloEquipo = "-1",
          string cantidadEquipo = "-1",
          string precioEquipo = "-1",
          string idProveedor = "-1",
          string descripcionEquipo = "-1")
        {
            return EquipoDato.filtrarTablaEquipo(
                TipoEquipo,
                marcaEquipo,
                modeloEquipo,
                cantidadEquipo,
                precioEquipo,
                idProveedor,
                descripcionEquipo
                );
        }
    }
}
