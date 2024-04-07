using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dolar;
            double cotacao;
            double real;

            Console.Write("Digite a quantidade de dólares: ");
            dolar = double.Parse(Console.ReadLine());
            Console.Write("Digite a cotação do dólar: ");
            cotacao = double.Parse(Console.ReadLine());

            real = cotacao * dolar;


            Console.Write("A quantide de reais é: ");
            Console.WriteLine(real);
        }
    }
}
