using System;
using System.Collections.Generic;
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
        private string claveUsuario;
        private string loginUsuario;
        private string nombreUsuario;
        private string apellidoUsuario;
        private bool activoUsuario;
        private int idEmpleado;

        public ModeloUsuario(int idUsuario, string claveUsuario, string loginUsuario, string nombreUsuario, string apellidoUsuario, bool activoUsuario, int idEmpleado)
        {
            this.idUsuario = idUsuario;
            this.claveUsuario = claveUsuario;
            this.loginUsuario = loginUsuario;
            this.nombreUsuario = nombreUsuario;
            this.apellidoUsuario = apellidoUsuario;
            this.activoUsuario = activoUsuario;
            this.idEmpleado = idEmpleado;
        }
        public string editarPerfil()
        {
            try
            {
                userData.editarMiInformacion(idUsuario, claveUsuario);
                LoginUsuario(loginUsuario, claveUsuario);
                return "Tú perfil ha sido actualizado satisfactoriamente";
            }
            catch (Exception ex)
            {
                return "El nombre de usuario ya está registrado, prueba con otro";
            }
        }
            public string LoginUsuario(string user, string pass)
            {
                return userData.Login(user, pass);
            }
    }
}

