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
    }
}
