using System;
using System.Collections.Generic;

namespace Biblioteca2021
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Autor> autores = new List<Autor>();

            Autor autor1 = new Autor();
            autor1.Nombre = "Stephen";
            autor1.ApPaterno = "King";
            autor1.ApMaterno = "López"; 
            autor1.Edad = 78;
            autor1.IdAutor = "ESO1234";
            autor1.Nacionalidad = "USA";

            Autor autor2 = new Autor();
            autor2.Nombre = "Gary";
            autor2.ApPaterno = "Jennings";
            autor2.ApMaterno = "Smith";
            autor2.Edad = 68;
            autor2.IdAutor = "GJO4321";
            autor2.Nacionalidad = "USA";

            autores.Add(autor1);
            autores.Add(autor2);


            Libro libro1 = new Libro();
            libro1.ISBN = "C45TRE34C";
            libro1.Titulo = "ESO, EL PÄYASO TENEBROSO";
            libro1.Autor = autor1;
            libro1.Editorial = "Planeta";
            libro1.Anio = 1978;
            libro1.Disponible = true;
            libro1.Precio = 400.00F;

            Libro libro2 = new Libro();
            libro2.ISBN = "DF5657";
            libro2.Titulo = "AZTECA";
            libro2.Autor = autor2;
            libro2.Editorial = "Novaro";
            libro2.Anio = 1981;
            libro2.Disponible = true;
            libro2.Precio = 423.50F;

            Lector lector1 = new Lector();
            lector1.Id = "APC1112233";
            lector1.Nombre = "Alejandro";
            lector1.ApPaterno = "Pérez";
            lector1.ApMaterno = "Córdova";
            lector1.Direccion = "C-13 #305 x 32B y 32D Fracc. San Crisanto, Mérida, Yucatán";
            lector1.Email = "alx.prz.crd@gmail.com";

            Lector lector2 = new Lector();
            lector2.Id = "BPR222233";
            lector2.Nombre = "Alberto";
            lector2.ApPaterno = "Pinzón";
            lector2.ApMaterno = "Rodríguez";
            lector2.Direccion = "C-20 #217 x 13B y 13C Col. Miguel Alemán, Mérida, Yucatán";
            lector2.Email = "alb.pin.rod@gmail.com";


            //string emailDeLector1 = lector1.GetEmail();
            //Console.WriteLine($"E-Mail del Lector1:{emailDeLector1}");

            lector1.MostrarDatos();
            Console.WriteLine("Presione una tecla para finalizar");
            Console.ReadKey();
            lector2.MostrarDatos();

            Console.WriteLine("Presione una tecla para finalizar");
            Console.ReadKey();
        }

        

    }
}
