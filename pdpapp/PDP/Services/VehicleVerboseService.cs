using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDP.Models;

namespace PDP.Services
{
    internal class VehicleVerboseService : IVehicleService
    {
        public void ImprimirDatos(Vehiculo vehiculo)
        {
            String s = String.Format("Datos del vehiculo modo verboso\nCapacidad De Peso: {0}\nPuestos: {1}\n Gasolina: {2}\n Posición Actual ({3},{4})",
                vehiculo.CapacidadDePeso,
                vehiculo.Puestos, 
                vehiculo.Gasolina, 
                vehiculo.PosicionActual.Item1, 
                vehiculo.PosicionActual.Item2);

            Console.WriteLine(s);
        }

        public void Destruir(Vehiculo vehiculo)
        {
            Console.WriteLine("Destruyendo Vehiculo");
            ImprimirDatos(vehiculo);
            vehiculo.CapacidadDePeso = 0;
            vehiculo.Puestos = 0;
            vehiculo.Gasolina = 0;
            vehiculo.PosicionActual = (0, 0);
            Console.WriteLine("Vehículo Destruido");
        }

        public List<Vehiculo> EncontrarPorTipo(Vehiculo[] vehiculos, string tipo)
        {
            List<Vehiculo> vehiculosEncontrados = new List<Vehiculo>();

            foreach(var v in vehiculos)
            {

                if (v.GetType().Name.Equals(tipo))
                {
                    Console.WriteLine(tipo + " Encontrado");
                    ImprimirDatos(v);
                    vehiculosEncontrados.Add(v);
                }
            }

            Console.WriteLine("Se encontraron " + vehiculosEncontrados.Count + " vehiculos de tipo: " + tipo);
            return vehiculosEncontrados;
        }

        public Vehiculo EncontrarVehiculoConMenorCantidadDeGasolina(Vehiculo[] vehiculos)
        {
            Vehiculo v = vehiculos[0];

            for (int i = 1; i < vehiculos.Length; i++)
            {
                Console.WriteLine("Comparando vehiculos");
                Console.WriteLine("Actual:");
                ImprimirDatos(v);
                Console.WriteLine("VS");
                ImprimirDatos(vehiculos[i]);
                v = vehiculos[i].Gasolina < v.Gasolina ? vehiculos[i] : v;
            }

            return v;
        }
    }
}
