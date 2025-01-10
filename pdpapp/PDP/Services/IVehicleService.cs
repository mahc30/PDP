using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDP.Models;

namespace PDP.Services
{
    internal interface IVehicleService
    {
        public void ImprimirDatos(Vehiculo vehiculo);
        public void Destruir(Vehiculo vehiculo);
        public List<Vehiculo> EncontrarPorTipo(Vehiculo[] vehiculos, String tipo);
        public Vehiculo EncontrarVehiculoConMenorCantidadDeGasolina(Vehiculo[] vehiculos);
    }
}
