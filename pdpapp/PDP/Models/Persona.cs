using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDP.Enums;

namespace PDP.Models
{
    public class Persona
    {
        public Persona(string nombre, uint edad, string telefono, TipoDocumento tipoDeDocumento, string documento)
        {
            Nombre = nombre;
            Edad = edad;
            Telefono = telefono;
            TipoDeDocumento = tipoDeDocumento;
            Documento = documento;
        }

        public String Nombre {  get; set; }
        public uint Edad { get; set; }
        public String Telefono {  get; set; }
        public TipoDocumento TipoDeDocumento { get; set; }
        public String Documento { get; set; }
        public String ColorDelCabello { get; set; }
        public String EstadoCivil {  get; set; }

        public void Saludar()
        {
            String saludo = String.Format("Hola me llamo {0} y tengo {1} años", 
                Nombre, 
                Edad);
            Console.WriteLine(saludo);
        }

        public void ImprimirDatos()
        {
            String datos = String.Format("Nombre: {0}\nEdad:{1}\nTelefono:{2}\nDocumento:{3} {4}", 
                Nombre, 
                Edad, 
                Telefono, 
                TipoDeDocumento.ToString(), 
                Documento);

            Console.WriteLine(datos);
        }
    }
}
