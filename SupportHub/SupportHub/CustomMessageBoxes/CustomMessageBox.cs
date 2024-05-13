using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentacion.CustomMessageBoxes
{
    internal class CustomMessageBox
    {
        public static void Exito(string encabezadoExito, string descripcionExito)
        {
            ExitoMessageBox _ = new(encabezadoExito, descripcionExito);
        }

        public static void Error(string encabezadoError, string descripcionError)
        {
            ErrorMessageBox _ = new(encabezadoError, descripcionError);
        }

        public static DialogResult Advertencia(string encabezadoAdvertencia, string descripcionAdvertencia)
        {
            AdvertenciaMessageBox _ = new(encabezadoAdvertencia, descripcionAdvertencia);
            if (_.obtenerConfirmacion() == DialogResult.Yes)
            {
                return DialogResult.Yes;
            }
            else
            {
                return DialogResult.No;
            }
        }
    }
}
