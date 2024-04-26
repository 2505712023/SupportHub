using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace Dominio
{
    internal class ModeloUsuario
    {
        UsuarioDato userData = new UsuarioDato();
        public bool LoginUsuario(string user, string pass) {
            return userData.Login(user,pass);
        }    
    }
}
