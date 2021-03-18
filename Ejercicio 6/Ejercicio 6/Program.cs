
//Escribir un programa en C# (console application) para imprimir la suma, multiplicar, 
//restar,dividir y el resto o residuo de dos números previamente ingresados.
using System;
namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, s, r, m,re;
            double d; 
            Console.Clear();
            Console.Write("Ingrese primer valor: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese segundo valor: ");
            b = Convert.ToInt32(Console.ReadLine());
            s = a + b;
            r = a - b;
            m = a * b;
            d = a / b;
            re = a % b;
            Console.WriteLine("{0} + {1} = {2} ", a,b,s);
            Console.WriteLine("{0} - {1} = {2} ", a, b, r);
            Console.WriteLine("{0} * {1} = {2} ", a, b, m);
            Console.WriteLine("{0} / {1} = {2} ", a,b,d);
            Console.WriteLine("{0} mod {1} = {2}", a, b, re);
            Console.WriteLine("Pulse una tecla para salir:  ");
            Console.ReadKey();
        }
    }
}
