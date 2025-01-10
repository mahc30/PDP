using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDP.Models;

namespace PDP.Services
{
    internal class VehicleService : IVehicleService
    {
        public void ImprimirDatos(Vehiculo vehiculo)
        {
            Console.WriteLine($"Detalles del Vehículo:\n - Tipo: {vehiculo.GetTipoVehiculo()}\n - Gasolina Restante: {vehiculo.Gasolina} litros");
        }

        public void Destruir(Vehiculo vehiculo)
        {
            Console.WriteLine($"Se ha eliminado el vehículo de tipo {vehiculo.GetTipoVehiculo()}.");
        }

        public List<Vehiculo> EncontrarPorTipo(Vehiculo[] vehiculos, string tipo)
        {
            List<Vehiculo> resultado = new List<Vehiculo>();
            foreach (var vehiculo in vehiculos)
            {
                if (vehiculo.GetTipoVehiculo().Equals(tipo, StringComparison.OrdinalIgnoreCase))
                {
                    resultado.Add(vehiculo);
                }
            }
            return resultado;
        }

        public Vehiculo EncontrarVehiculoConMenorCantidadDeGasolina(Vehiculo[] vehiculos)
        {
            Vehiculo menor = vehiculos[0];
            foreach (var vehiculo in vehiculos)
            {
                if (menor == null || vehiculo.Gasolina < menor.Gasolina)
                {
                    menor = vehiculo;
                }
            }
            return menor;
        }
    }
}
