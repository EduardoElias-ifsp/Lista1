﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double area;
            double diagonal;
      
            
            Console.Write("Digite a diagonal do quadrado: ");
            diagonal = double.Parse(Console.ReadLine());


            area = diagonal * diagonal / 2;
            Console.Write("A área do quadrado é: {0}",area);
        }
    }
}
