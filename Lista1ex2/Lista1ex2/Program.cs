using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aresta;
            int area;

            Console.Write("Digite a aresta do quadrado: ");
            aresta = int.Parse(Console.ReadLine());


            area = aresta * aresta; ;

            Console.Write("A área do quadrado é: {0}", area);
        }
    }
}
