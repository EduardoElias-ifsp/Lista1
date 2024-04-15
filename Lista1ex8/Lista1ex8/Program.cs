using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius;
            double resultado;

            Console.Write("Digite a temperatura em graus Celcius:");
            celsius = int.Parse(Console.ReadLine());


            resultado = celsius * 9 / 5 + 32;

            Console.Write(celsius);
            Console.Write(" graus Celcius em Fahrenheit: {0}",resultado);
        }
    }
}
