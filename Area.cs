using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca2021
{
    class Area
    {
        private List<Estante> estantes;
        private string idArea;
        private string descripcion;

        public string IdArea { get => idArea; set => idArea = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        internal List<Estante> Estantes { get => estantes; set => estantes = value; }

        public void ShowInfo()
        {
            Console.WriteLine($"Área: {idArea}   Descripción: {descripcion}");
        }
    }
}
