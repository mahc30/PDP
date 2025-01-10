using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PDP.Util
{
    public static class MyMath
    {
        public static uint FindLargestPrime(uint max)
        {
            if (max < 2) return 2;
            if (IsPrime(max)) return max;
            return FindLargestPrime(max - 1);
        }

        public static bool IsPrime(uint number)
        {
            if (number < 2) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            uint limit = (uint)Math.Sqrt(number);
            for (uint i = 3; i <= limit; i += 2)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        public static double Cuadrado(double a) => a * a; 
        public static int Cuadrado(int a) => a * a; 

        public static double[] CalcularListaAlCuadrado(double[] lista)
        {
            int i;

            for (i = 0; i < lista.Length; i++)
            {
                lista[i] = lista[i] * lista[i];
            }

            return lista;
        }

        public static List<double> CalcularListaAlCuadrado(List<double> lista)
        {
            List<double> cuadrados = lista.Select(x => Cuadrado(x)).ToList();
            return cuadrados;
        }

        public static List<int> CalcularListaAlCuadradoFiltrarYOrdenar(List<int> lista, int max)
        {
            List<int> cuadrados = lista.Select(x => Cuadrado(x))
                .Where(x => x < max)
                .Order()
                .ToList();
            return cuadrados;
        }

        public static Func<int, int> GenerarFuncionPotencia(int exponente)
        {
            return x => (int)Math.Pow(x, exponente);
        }
    }
}
