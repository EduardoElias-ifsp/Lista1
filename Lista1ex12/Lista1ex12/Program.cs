using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v1;
            double v2;
            double v3;
            double v4;
            double v5;
            double pagamento;
            double troco;


            Console.Write("Digite o valor do primeiro produto: ");
            v1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do segundo produto: ");
            v2 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do terceiro produto: ");
            v3 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do quarto produto: ");
            v4 = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor do quinto produto: ");
            v5 = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do pagamento: ");
            pagamento = double.Parse(Console.ReadLine());

            troco = pagamento - (v1 + v2 + v3 + v4 + v5);

            Console.Write("O troco a ser devolvido é: ");
            Console.WriteLine(troco);
        }
    }
}
