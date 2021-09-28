using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca2021
{
    class Libro
    {
        string isbn;
        private string titulo;
        private Autor autor;
        private string editorial;
        private int anio;
        bool disponible = true;
        private float precio;

        public string ISBN { get => isbn; set => isbn = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public int Anio { get => anio; set => anio = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
        public float Precio { get => precio; set => precio = value; }
        internal Autor Autor { get => autor; set => autor = value; }

        public void MostrarDatos()
        {
            Console.WriteLine("Estos son los datos del libro:");
            Console.WriteLine($"ISBN: {isbn}");
            Console.WriteLine($"Titulo: {titulo}");
            Console.WriteLine($"Editorial: {editorial}");
            Console.WriteLine($"Año: {anio}");
            Console.WriteLine($"Disponible: {disponible}");
            Console.WriteLine($"Precio: {precio}");
            autor.MostrarDatos();
            

            Console.WriteLine($"");

        }

    }
}
