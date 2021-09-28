using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca2021
{
    class Autor
    {
        private string idAutor;
        private string nombre;
        private string apPaterno;
        private string apMaterno;
        private bool vivo;
        private int edad;
        private string nacionalidad;
        string email;

        public string IdAutor { get => idAutor; set => idAutor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApPaterno { get => apPaterno; set => apPaterno = value; }
        public string ApMaterno { get => apMaterno; set => apMaterno = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string NombreCompleto { get => $"{nombre} {apPaterno} {apMaterno}"; }

        public void MostrarDatos()
        {
            Console.WriteLine("Estos son los datos del autor:");
            Console.WriteLine();
            Console.WriteLine($"ID del autor: {IdAutor}");
            Console.WriteLine($"Nombre Completo: {NombreCompleto}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Nacionalidad: {Nacionalidad}");
        }
    }
}
