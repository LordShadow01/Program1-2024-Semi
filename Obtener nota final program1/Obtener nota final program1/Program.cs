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
            //Obtener Nota Final Computo 1 Programa 1
            Console.Write("Lab 1 Computo 1: ");
            double lab1_c1 = double.Parse(Console.ReadLine());

            Console.Write("Lab 2 Computo 1: ");
            double lab2_c1 = double.Parse(Console.ReadLine());

            Console.Write("Parcial 1 Computo 1: ");
            double parcial1_c1 = double.Parse(Console.ReadLine());

            //Computo 1
            double c1 = lab1_c1 * 30 / 100 + lab2_c1 * 30 / 100 + parcial1_c1 * 40 / 100;
            Console.WriteLine("La nota total del Computo 1: {0:F2}", c1);

            Console.WriteLine();

            //Obtener Nota Final Computo 2 Programa 1
            Console.Write("Lab 1 Computo 2: ");
            double lab1_c2 = double.Parse(Console.ReadLine());

            Console.Write("Lab 2 Computo 2: ");
            double lab2_c2 = double.Parse(Console.ReadLine());

            Console.Write("Parcial 1 Computo 2: ");
            double parcial1_c2 = double.Parse(Console.ReadLine());

            //Computo 2
            double c2 = lab1_c2 * 30 / 100 + lab2_c2 * 30 / 100 + parcial1_c2 * 40 / 100;
            Console.WriteLine("La nota total del Computo 2: {0:F2}", c2);

            Console.WriteLine();

            //Obtener Nota Final Computo 3 Programa 1
            Console.Write("Lab 1 Computo 3: ");
            double lab1_c3 = double.Parse(Console.ReadLine());

            Console.Write("Lab 2 Computo 3: ");
            double lab2_c3 = double.Parse(Console.ReadLine());

            Console.Write("Parcial 1 Computo 3: ");
            double parcial1_c3 = double.Parse(Console.ReadLine());

            //Computo 3
            double c3 = lab1_c3 * 30 / 100 + lab2_c3 * 30 / 100 + parcial1_c3 * 40 / 100;
            Console.WriteLine("La nota total del Computo 3: {0:F2}", c3);

            //pausa
            Console.ReadLine();
        }
    }
}
