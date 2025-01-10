using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PDP.Models
{
    internal class Empleado
    {
        public String Nombre;
        public short Edad;
        public String Telefono;
        public String Documento;
        public String TipoDeSangre;

        public Empleado(string nombreEmpleado, short edadEmpleado, string telefonoEmpleado, string documentoEmpleado, string tipoDeSangreEmpleado)
        {
            Nombre = nombreEmpleado;
            Edad = edadEmpleado;
            Telefono = telefonoEmpleado;
            Documento = documentoEmpleado;
            TipoDeSangre = tipoDeSangreEmpleado;
        }

        public Empleado(string nombreEmpleado)
        {
            Nombre = nombreEmpleado;
            Edad = 0;
            Telefono = "NA";
            Documento = "NA";
            TipoDeSangre = "O+";
        }

        public Empleado()
        {
            Nombre = "";
        }

        public void ImprimirDatos()
        {
            Console.WriteLine(Nombre + " " + Telefono + " " + Edad + " " + Documento + " " + TipoDeSangre);
        }
    }
}
