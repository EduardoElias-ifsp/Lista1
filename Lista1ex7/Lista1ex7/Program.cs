using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex7
{
    internal class Program
    {
        static void Main(string[] args)
        { 

            double entrada;
            double saida;

       
            Console.Write("Digite a quantidade de milhas marítimas: ");
            entrada = double.Parse(Console.ReadLine());

            saida = entrada * 1852 / 1000;


            Console.Write("O resultado da conversão é: ");
            Console.WriteLine(saida);
        }
    }
}
