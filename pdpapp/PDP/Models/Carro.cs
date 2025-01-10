using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDP.Models
{
    internal class Carro : Vehiculo
    {

        internal uint NumeroDeRuedas {  get; set; }
        public Carro(uint gasolina, uint capacidadDePeso, ushort puestos, uint numeroDeRuedas)
        {
            Gasolina = gasolina;
            CapacidadDePeso = capacidadDePeso;
            Puestos = puestos;
            NumeroDeRuedas = numeroDeRuedas;
        }

        public override void Moverse(int x, int y)
        {
            String salida = String.Format("Moverse del punto ({0},{1}) A ({2},{3})", PosicionActual.Item1, PosicionActual.Item2, x, y);
            Console.WriteLine(salida);
        }

        public void TocarBocina()
        {
            Console.WriteLine("Beep...");
        }
    }
}
