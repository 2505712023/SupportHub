﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.Cache
{
    public static class CacheInicioUsuario
    {
        public static int IdUser { get; set; }
        public static string? password { get; set; }
        public static string? user { get; set;}   
        public static string? nombreUser { get; set; }
        public static string? apellidoUser { get; set; }
        public static ArrayList? rolesUser { get; set; }
        public static ArrayList? permisosUser { get; set; }
        public static string? empleado { get; set; }
        public static int idEmpleado { get; set; }
    }
}
