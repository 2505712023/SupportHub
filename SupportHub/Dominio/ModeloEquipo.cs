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
    }
}
