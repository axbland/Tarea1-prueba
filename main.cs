using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRUEBA1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Ingrese el nombre:");
            string nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre}!");

            Console.WriteLine("Ingrese su apellido:");
            string apellido = Console.ReadLine();
            Console.WriteLine($"Su apellido es: {apellido}");

            Console.ReadLine();
        }
    }
}
