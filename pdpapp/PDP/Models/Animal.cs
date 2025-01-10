using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDP.Models
{
    abstract class Animal
    {
        string Nombre { get; set; }
        uint Edad { get; set; }

        public abstract void Hablar();
    }

    class Mamifero : Animal
    {
        public Mamifero() { }
        public override void Hablar()
        {
            Console.WriteLine("Hola soy un mamifero");
        }
    }

    class Pez : Animal
    {
        public Pez() { }

        public override void Hablar()
        {
            Console.WriteLine("Hola soy un Pez");
        }
    }

    class Caracol : Animal
    {
        public Caracol() { }
        public override void Hablar()
        {
            Console.WriteLine("Hola soy un Caracol");
        }
    }

    class Perro : Mamifero
    {
        public Perro() { }
        public override void Hablar()
        {
            Console.WriteLine("Hola soy un Perro");
        }
    }

    class Gato : Mamifero
    {
        public Gato() { }
        public void Arañar()
        {
            Console.WriteLine("Gato araña");
        }
    }
}
