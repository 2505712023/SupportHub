using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Dominio
{
    public class ModeloUsuario
    {
        UsuarioDato userData = new UsuarioDato();

        private int idUsuario;
        private string nuevaContraseña;

        public ModeloUsuario()
        {

        }

        public ModeloUsuario(int idUsuario, string nuevaContraseña)
        {
            this.idUsuario = idUsuario;
            this.nuevaContraseña = nuevaContraseña;
        }

        public string EditarPerfil()
        {
            try
            {
                userData.ModificarContraseña(idUsuario, nuevaContraseña);
                return "Tu perfil ha sido actualizado satisfactoriamente";
            }
            catch (Exception ex)
            {
                return "Hubo un error al intentar actualizar tu perfil: " + ex.Message;
            }
        }
        public string LoginUsuario(string user, string pass)
            {
                return userData.Login(user, pass);
            }

        //Hecho por KEVIN
        public DataTable mostrarUsuario()
        {
            DataTable tabla = new DataTable();
            tabla = userData.obtenerUsuario();
            return tabla;
        }

        public DataTable filtrarTablaUsuario(string loginUsuario = "-1", string nombreUsuario = "-1", string apellidoUsuario = "-1")
        {
            return userData.filtrarTablaUsuario(loginUsuario, nombreUsuario, apellidoUsuario);
        }

        public DataTable Obtenernombres()
        {
        return userData.ObtenerNombres();
        }
        public DataTable ObtenerApellidos()
        {
            return userData.ObtenerApellidos();
        }

        public DataTable ObtenerRoles()
        { return userData.ObtenerRoles(); }

        public void ActualizarUsuario(string LoginUsuario, string nombreUsuario, string apellidoUsuario, string contrasenia, int activo, string tipousuario) 
        {
            userData.ActualizarUsuario(LoginUsuario, nombreUsuario,apellidoUsuario,contrasenia,activo,tipousuario);
        }

        public void InsertarUsuario(string LoginUsuario, string NombreUsuario, string ApellidoUsuario, string Contrasenia, int ActivoUsuario)
        {
            userData.InsertarUsuario(LoginUsuario, NombreUsuario, ApellidoUsuario, Contrasenia, ActivoUsuario);
        }
      
        public bool ValidarLogin(string login)
        {
            return !userData.ValidarLogin(login);
        }
        public void EliminarUsuario( string loginUsuario)
        {
            userData.EliminarUsuario(loginUsuario);
        }
        public string ObtenerIdUsuario(string IdLogin)
        {
            return ObtenerIdUsuario(IdLogin);
        }
        public void InsertarUsuarioxRol(int IdRol)
        {
            userData.InsertarUsuarioxRol(IdRol);
        }
    }
}
