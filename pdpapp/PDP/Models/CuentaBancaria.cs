using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDP.Models
{
    internal class CuentaBancaria
    {
        String Titular;
        private double Saldo;

        public CuentaBancaria(String Titular, double Saldo)
        {
            this.Titular = Titular;
            _ = Saldo > 0 ? this.Saldo = Saldo : this.Saldo = 0;
        }

        public void Depositar(double dinero)
        {
            if(dinero > 0) this.Saldo += dinero;
        }

        public void Retirar(double dinero)
        {
            if(dinero <= Saldo)this.Saldo -= dinero;
        }
    }
}
