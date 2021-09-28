using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca2021
{
    class Biblioteca
    {
        string nombre;
        string direccion;

        List<Area> areas;
        private List<Lector> lectoresRegistrados = new List<Lector>();
        List<Lector> lectoresListaNegra = new List<Lector>();
        List<Libro> librosPrestados = new List<Libro>();
        List<Libro> librosDevueltos = new List<Libro>();

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        internal List<Area> Areas { get => areas; set => areas = value; }
        //internal List<Lector> LectoresRegistrados { get => lectoresRegistrados; set => lectoresRegistrados = value; }
        internal List<Lector> LectoresListaNegra { get => lectoresListaNegra; set => lectoresListaNegra = value; }
        internal List<Libro> LibrosPrestados { get => librosPrestados; set => librosPrestados = value; }
        internal List<Libro> LibrosDevueltos { get => librosDevueltos; set => librosDevueltos = value; }

        //public void PrestarLibro(Lector lectorPrestamo, Libro libroPrestamo)
        //{
        //    if(!lectorPrestamo.ListaNegra)
        //    { 
        //    if (libroPrestamo.Disponible)
        //    {
        //        LibrosPrestados.Add(libroPrestamo);
        //        lectorPrestamo.PrestarLibro(libroPrestamo);
        //        Seccion seccionDelLibro = libroPrestamo.Ubicacion.Seccion;
        //        seccionDelLibro.Libros.Remove(libroPrestamo);
        //        libroPrestamo.Disponible = false;
        //    }
        //    else
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine("El libro ya ha sido dado en préstamo");
        //        Console.WriteLine();
        //        Console.WriteLine("Presione una tecla para contniuar...");
        //        Console.ReadKey();
        //    }
        //    }
        //    else
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine("El lector está en la lista negra");
        //        Console.WriteLine();
        //        Console.WriteLine("Presione una tecla para contniuar...");
        //        Console.ReadKey();
        //    }
        //}

        //public void DevolverLibro(Lector lectorPrestamo, Libro libroPrestamo)
        //{
        //        LibrosPrestados.Remove(libroPrestamo);
        //        lectorPrestamo.DevolverLibro(libroPrestamo);
        //        LibrosDevueltos.Add(libroPrestamo);
        //        libroPrestamo.Disponible = true;
        //}

        //public void RegresarLibrosASeccion()
        //{
        //    foreach(Libro libroT in LibrosDevueltos)
        //    {
        //        Seccion seccionLibro = libroT.Ubicacion.Seccion;
        //        seccionLibro.Libros.Add(libroT);
        //        libroT.Disponible = true;
        //    }
        //}

        //public void LibrosXLector()
        //{
        //    int i = 0;
        //    int howmany = lectoresRegistrados.Count;
        //    foreach(Lector lectorT in lectoresRegistrados)
        //    {
        //        Console.WriteLine($"Lector {i+1} de {howmany}:");
        //        lectorT.ImprimirListaPrestados();
        //        i++;
        //    }
        //}

        //public void LibrosYaDevueltos()
        //{
        //    int i = 0;
        //    int howmany = LibrosDevueltos.Count;
        //    foreach (Libro libroT in LibrosDevueltos)
        //    {
        //        Console.WriteLine($"Libro {i + 1} de {howmany}:");
        //        libroT.mostrar();
        //        i++;
        //    }
        //}

        //public void AgregarLectorAListaNegra(Lector lectorLN)
        //{
        //    LectoresListaNegra.Add(lectorLN);
        //    lectorLN.ListaNegra = true;
        //    Console.WriteLine($"Lector {lectorLN.IdLector}: {lectorLN.NombreCompleto} ha sido agregado a la lista negra.");
        //}

        //public void AgregarLectorAListaRegistrados(Lector lectorRegistrado)
        //{
        //    lectoresRegistrados.Add(lectorRegistrado);
        //    Console.WriteLine($"Lector {lectorRegistrado.IdLector}: {lectorRegistrado.NombreCompleto} ha sido registrado.");
        //}

        //public void LectoresYaRegistrados()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Lectores registrados");
        //    int i = 0;
        //    int howmany = lectoresRegistrados.Count;
        //    foreach (Lector lectorT in lectoresRegistrados)
        //    {
        //        Console.WriteLine($"Lector {i + 1} de {howmany}:");
        //        lectorT.mostrarDatos();
        //        i++;
        //    }
        //}

        //public void LectoresEnListaNegra()
        //{
        //    Console.Clear();
        //    Console.WriteLine("Lectores en lista negra");
        //    int i = 0;
        //    int howmany = LectoresListaNegra.Count;
        //    foreach (Lector lectorT in LectoresListaNegra)
        //    {
        //        Console.WriteLine($"Lector {i + 1} de {howmany}:");
        //        lectorT.mostrarDatos();
        //        i++;
        //    }
        //}
    }
}
