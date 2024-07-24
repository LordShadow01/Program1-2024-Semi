using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obtener_nota_final_program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Obtener Nota Final Computo 1 Program 1
            Console.Write("Lab1: ");
            double lab1 = double.Parse(Console.ReadLine()); // 9

            Console.Write("Lab2: ");
            double lab2 = double.Parse(Console.ReadLine()); //7

            Console.Write("Parcial 1: ");
            double parcial1 = double.Parse(Console.ReadLine()); //9

            double c1 = lab1 * 30 / 100 + lab2 * 30 / 100 + parcial1 * 40 / 100;
            Console.WriteLine("La nota de c1 es: {0}", c1);

            //pausa
            Console.ReadLine();
        }
    }
}
