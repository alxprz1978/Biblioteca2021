using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca2021
{
    class Estante
    {
        private List<Seccion> secciones;
        private string idEstante;
        private string descripcion;

        public string IdEstante { get => idEstante; set => idEstante = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        internal List<Seccion> Secciones { get => secciones; set => secciones = value; }

        public void ShowInfo()
        {
            Console.WriteLine($"Estante: {idEstante}   Descripción: {descripcion}");
        }
    }
}
