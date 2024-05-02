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

        public static DataTable filtrarTablaEntregasPorCodigo(string codEntrega)
        {
            return EntregaDato.filtrarTablaEntregasPorCodigo(codEntrega);
        }
    }
}
