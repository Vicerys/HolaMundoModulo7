using System;
using System.Collections.Generic;
using System.Text;

namespace InicioDeSesion
{
    public class IniciarSersionService
    {
        public bool IniciarSesion(string usuario, string contrasena)
        {
            if (usuario == "admin" && contrasena == "password123")
            {
                return true;
            }
            return false;

        }
    }
}
