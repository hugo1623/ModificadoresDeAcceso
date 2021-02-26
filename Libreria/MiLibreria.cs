using System;

namespace Libreria
{

    public class MiLibreriaCliente
    {
        public void MetodoCliente()
        {
            var cliente = new MiLibreria();
            cliente.PropiedadPublica = 5;
            cliente.PropiedadInternal = 5;
            cliente.PropiedadProtectedInternal = 5;
        }
    }

    public class MiLibreria
    {
        public int PropiedadPublica { get; set; }
        private int PropiedadPrivada { get; set; }
        internal int PropiedadInternal { get; set; }
        protected int PropiedadProtected { get; set; }
        protected internal int PropiedadProtectedInternal { get; set; }
        private protected int PropiedadPrivateProtected { get; set; }

        public void MetodoDemo()
        {
            PropiedadPrivada = 5;
            PropiedadPublica = 5;
            PropiedadProtected = 5;
            PropiedadProtectedInternal = 5;
            PropiedadPrivateProtected = 5;
        }
        public void MetodoNuevo()
        {
            PropiedadPrivada = 555;
            PropiedadInternal = 5;
            PropiedadProtected = 5;
        }
    }

    public class MiLibreriaHija : MiLibreria
    {
        public void MetodoHijo()
        {
            PropiedadInternal = 5;
            PropiedadProtected = 5;
            PropiedadProtectedInternal = 5;
            PropiedadPrivateProtected = 5;
        }
    }

}
