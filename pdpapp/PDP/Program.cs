// See https://aka.ms/new-console-template for more information
using System;
using PDP.Enums;
using PDP.Models;
using PDP.Services;
using PDP.Util;



var esMenor = (int numero, int limite) => numero < limite;

list.Select(x => MyMath.Cuadrado(x))
    .Order()
    .Where(x => !esMenor(x, 500) && x % 2 == 1)
    .ToList()
    .ForEach(Console.WriteLine);

List<int> list = new List<int>() { 1, 2, 5, 63, 34, 23, 31, 13, 14, 17, 84, 124 };

var esMayorDeEdad = (int edad) => edad > 18 ? "Es mayor de edad" : "Es menor de edad";

list.ForEach(x => Console.WriteLine(esMayorDeEdad(x)));