using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exConversorTemperaturas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cel, fahr, kel;

            Console.WriteLine("### CONVERSOR DE TEMPURATURAS ###");

            Console.Write("Temperatura (°C): ");
            cel = double.Parse(Console.ReadLine());

            fahr = cel * 9 / 5 + 32;
            Console.WriteLine(cel + " °C = " + fahr + " °F");

            kel = cel + 273.15;
            Console.WriteLine(cel + " °C = " + kel + " °K");
            Console.ReadKey();
        }
    }
}
