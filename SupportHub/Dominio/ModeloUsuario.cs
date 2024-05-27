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

        public DataTable filtrarTablaUsuario(string loginUsuario = "-1", string nombresUsuario = "-1", string apellidosUsuario = "-1")
        {
            return userData.filtrarTablaUsuario(loginUsuario, nombresUsuario, apellidosUsuario);
        }

        public string ObtenerNombreEmpleado(int idEmpleado)
        {
            return userData.ObtenerNombreEmpleado(idEmpleado);
        }

        public string ObtenerApellidoEmpleado(int idEmpleado)
        {
            return userData.ObtenerApellidoEmpleado(idEmpleado);
        }

        public DataTable ObtenerRoles()
        {
            return userData.ObtenerRoles();
        }

        public void ActualizarUsuario(string loginUsuario, string? contraseniaUsuario, string nombresUsuario, string apellidosUsuario, int activoUsuario, int idEmpleado)
        {
            userData.ActualizarUsuario(loginUsuario, contraseniaUsuario, nombresUsuario, apellidosUsuario, activoUsuario, idEmpleado);
        }

        public void InsertarUsuario(string LoginUsuario, string NombreUsuario, string ApellidoUsuario, string Contrasenia, int ActivoUsuario, int idEmpleado)
        {
            userData.InsertarUsuario(LoginUsuario, NombreUsuario, ApellidoUsuario, Contrasenia, ActivoUsuario, idEmpleado);
        }
      
        public bool ValidarLogin(string login)
        {
            return !userData.ValidarLogin(login);
        }

        public void EliminarUsuario( string loginUsuario)
        {
            userData.EliminarUsuario(loginUsuario);
        }

        public int ObtenerIdUsuario(string loginUsuario)
        {
            return userData.ObtenerIdUsuario(loginUsuario);
        }

        public void InsertarUsuarioxRol(int idRol, string loginUsuario)
        {
            userData.InsertarUsuarioxRol(idRol, loginUsuario);
        }

        public DataTable ObtenerEmpleados(int? idEmpleado)
        {
            return userData.ObtenerEmpleados(idEmpleado);
        }

        public bool ValidarRolActivoXUsuario(string loginUsuario, int idRol)
        {
            return userData.ValidarRolActivoXUsuario(loginUsuario, idRol);
        }

        public void EliminarUsuarioxRol(int idRol, string loginUsuario)
        {
            userData.EliminarUsuarioxRol(idRol, loginUsuario);
        }
    }
}
