using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria
{
    public class NuevaClase
    {
        public void OtroMetodo()
        {
            var y = new MiLibreria();
            y.PropiedadInternal = 5;
        }
    }

    class ClaseBase //Internal
    {

    }

    public class MiClase : ClaseBase
    {

    }


    internal class ClaseInterna { }
    public class ClaseX
    {
        public void MetodoRecibeClaseInterna(ClaseInterna claseInterna) { }
    }

}
