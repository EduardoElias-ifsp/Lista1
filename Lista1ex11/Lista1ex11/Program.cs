using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double resultado;

            Console.Write("Digite o número a ser elevado: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("Digite por quanto vai elevar: ");
            y = double.Parse(Console.ReadLine());

            resultado = Math.Pow(x, y);

            Console.Write("O resultado é: ");
            Console.WriteLine(resultado);
        }
    }
}
