using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDP.Models;

namespace PDP.Services
{
    internal class VehicleLinqService : IVehicleService
    {
        public void ImprimirDatos(Vehiculo vehiculo)
        {
            Console.WriteLine($"LINQ Service: Tipo: {vehiculo.GetTipoVehiculo()}, Gasolina: {vehiculo.Gasolina}L");
        }

        public void Destruir(Vehiculo vehiculo)
        {
            Console.WriteLine($"El vehículo {vehiculo.GetTipoVehiculo} ha sido destruido.");
        }

        public List<Vehiculo> EncontrarPorTipo(Vehiculo[] vehiculos, string tipo)
        {
            return vehiculos.Where(v => v.GetTipoVehiculo().Equals(tipo, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Vehiculo EncontrarVehiculoConMenorCantidadDeGasolina(Vehiculo[] vehiculos)
        {
            return vehiculos.OrderBy(v => v.Gasolina).FirstOrDefault();
        }
    }
}
