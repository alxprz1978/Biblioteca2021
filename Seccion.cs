using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca2021
{
    class Seccion
    {
        private List<Libro> libros;
        private string idSeccion;
        private string descripcion;

        public string IdSeccion { get => idSeccion; set => idSeccion = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        internal List<Libro> Libros { get => libros; set => libros = value; }

        public void ShowInfo()
        {
            Console.WriteLine($"Seccion: {idSeccion}   Descripción: {descripcion}");
        }
    }
}
