using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca2021
{
    class MiembroBiblioteca
    {
        private string id;
        private string nombre;
        private string apPaterno;
        private string apMaterno;
        private string direccion;
        private string email;
        private int edad;

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApPaterno { get => apPaterno; set => apPaterno = value; }
        public string ApMaterno { get => apMaterno; set => apMaterno = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string NombreCompleto { get => $"{nombre} {apPaterno} {apMaterno}";}
        public string Email { get => email; set => email = value; }
        public int Edad { get => edad; set => edad = value; }

        public void MostrarDatos()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Nombre: {NombreCompleto}");
            Console.WriteLine($"Edad: {Edad}");
            Console.WriteLine($"Dirección: {Direccion}");
            Console.WriteLine($"E-Mail: {Email}");
        }

    }
}
