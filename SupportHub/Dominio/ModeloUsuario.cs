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
        private string nuevaContraseña;

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
    }
}
