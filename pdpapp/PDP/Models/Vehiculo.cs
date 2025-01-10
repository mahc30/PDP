using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDP.Models
{
    internal abstract class Vehiculo
    {
      
        internal uint Gasolina { get; set; }
        internal uint CapacidadDePeso {  get; set; }
        internal ushort Puestos { get; set; }
        internal (int, int) PosicionActual = (0, 0);

        public abstract void Moverse(int x, int y);

        public String GetTipoVehiculo()
        {
            return this.GetType().Name;
        }
    }
}
