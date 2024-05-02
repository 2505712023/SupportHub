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

        public static DataTable filtrarTablaEntregas(string codEntrega = "-1", string nombreTipoEntrega = "-1", string observacionesEntrega = "-1")
        {
            return EntregaDato.filtrarTablaEntregas(codEntrega, nombreTipoEntrega, observacionesEntrega);
        }

        public static int eliminarEntrega(string? codEntrega)
        {
            return EntregaDato.eliminarEntrega(codEntrega);
        }
    }
}
