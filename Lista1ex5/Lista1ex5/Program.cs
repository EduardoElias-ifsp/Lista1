using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex5
{
    internal class Program
    {
        static void Main(string[] args) { 

        int v1;
        int v2;
        int v3;
        int v4;
        int media;

            Console.Write("Digite o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            v2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro valor: ");
            v3 = int.Parse(Console.ReadLine());
            Console.Write("Digite o quarto valor: ");
            v4 = int.Parse(Console.ReadLine());

            media = (v1 + v2 + v3 + v4) / 4;
            Console.Write("A média dos valores é: {0}",media);
        }
}
}
