using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDP.Models
{
    internal class Avion : Vehiculo
    {
        public Avion(uint gasolina, uint capacidadDePeso, ushort puestos)
        {
            Gasolina = gasolina;
            CapacidadDePeso = capacidadDePeso;
            Puestos = puestos;
        }

        public override void Moverse(int x, int y)
        {
            String salida = String.Format("Volar del punto ({0},{1}) A ({2},{3})", PosicionActual.Item1, PosicionActual.Item2, x, y);
            Console.WriteLine(salida);
        }

        public void Despegar()
        {
            Console.WriteLine("Despegando...");
        }

        public void Aterrizar()
        {
            Console.WriteLine("Aterrizando...");
        }
    }
}
