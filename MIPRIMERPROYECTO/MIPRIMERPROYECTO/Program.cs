﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIPRIMERPROYECTO
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.Write("num 1:");
            int num1 = int.Parse(Console.ReadLine()); //"5" -> 5

            Console.Write("num 2:");
            int num2 = int.Parse(Console.ReadLine());

            int respuesta = num1 + num2;
            Console.Write("La sumas de {0} + {1} ={2}", num1, num2, respuesta);

            //pausa
            Console.ReadLine();
        }
    }
}
