using DataAccess;
using System.Data;

namespace Dominio
{
    public class ModeloProveedor
    {
        private ProveedorDato proveedor = new();

        public DataTable MostrarProveedores()
        {
            return proveedor.ObtenerProveedores();
        }

        public void EliminarProveedor(int idProveedor)
        {
            proveedor.EliminarEmpleado(idProveedor);
        }

        public void AgregarProveedor(string codProveedor, string nombreProveedor, string direccion, string telefono)
        {
            proveedor.AgregarProveedor(codProveedor, nombreProveedor, direccion, telefono);
        }

        public void ActualizarProveedor(int idProveedor, string codProveedor, string nombreProveedor, string direccion, string telefono)
        {
            proveedor.ActualizarProveedor(idProveedor, codProveedor, nombreProveedor, direccion, telefono);
        }

        public DataTable ObtenerProveedor(string codProveedor = "-1", string nombreProveedor = "-1")
        { 
            return proveedor.ObtenerProveedor(codProveedor, nombreProveedor);
        }
    }
}
