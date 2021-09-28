using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca2021
{
    class Ubicacion
    {
        private Area area;
        private Estante estante;
        private Seccion seccion;

        internal Area Area { get => area; set => area = value; }
        internal Estante Estante { get => estante; set => estante = value; }
        internal Seccion Seccion { get => seccion; set => seccion = value; }

        public void ShowInfo()
        {
            area.ShowInfo();
            estante.ShowInfo();
            seccion.ShowInfo();
        }
    }
}
