using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDP.Enums;

namespace PDP.Models
{
    

    internal class Biblioteca
    {
        private readonly String Nombre;
        private readonly String Direccion;
        private List<Libro> Libros;
        private List<Persona> Usuarios;
        private Persona[] Bibliotecarios = new Persona[3];
        private List<Alquiler> Alquileres;
        private Administrador Administrador;

        
    }

    internal class Alquiler
    {
        private Persona Persona { get; set; }
        private Libro Libro { get; set; }
        private DateTime FechaInicio { get; set; }
        private DateTime FechaFin { get; set; }

    }

    internal class Administrador : Persona
    {
        public Administrador(string nombre, uint edad, string telefono, TipoDocumento tipoDeDocumento, string documento) : base(nombre, edad, telefono, tipoDeDocumento, documento)
        {
        }

        private Biblioteca BibliotecaResponsable { get; set; }
    }

}
