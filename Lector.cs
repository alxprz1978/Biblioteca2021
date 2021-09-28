using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca2021
{
    class Lector : MiembroBiblioteca
    {
        
        List<Libro> librosPrestados = new List<Libro>();

        internal List<Libro> LibrosPrestados { get => librosPrestados; set => librosPrestados = value; }

        public void PrestarLibro(Libro libroPrestado)
        {

            LibrosPrestados.Add(libroPrestado);
            Console.WriteLine("El libro ha sido prestado");

        }

        public void DevolverLibro(Libro libroDevuelto)
        {
            LibrosPrestados.Remove(libroDevuelto);
        }

        public void ImprimirListaPrestados()
        {
            //if (librosPrestados.Count > 0)
            //{
            //    Console.WriteLine($"Estos son los libros prestados por: {idLector} _ {NombreCompleto}");
            //    foreach (Libro libroT in librosPrestados)
            //    {
            //        //libroT.mostrar();
            //        Console.WriteLine();
            //    }
            //}
            //else
            //{
            //    Console.WriteLine($"El lector: {idLector} _ {NombreCompleto} no tiene libros prestados");
            //}
            //Console.WriteLine("Presione una tecla para continuar...");
            //Console.ReadKey();
        }

    }
}
