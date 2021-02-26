using Libreria;
using System;
using System.Collections;

namespace Sesion1
{
    class Programa
    {
        static void Main(string[] args)
        {
            var x = new MiLibreria();
            x.PropiedadPublica = 5;
        }
    }

    public class ClaseHija : MiLibreria
    {
        public void MetodoHijo()
        {
            PropiedadProtected = 5;
            PropiedadProtectedInternal = 5;
        }
    }
}
