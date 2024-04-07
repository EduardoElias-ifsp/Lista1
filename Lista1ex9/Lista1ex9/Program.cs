using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double diametro;
            double area;

            Console.Write("Digite o diâmetro do círculo:");
            diametro = int.Parse(Console.ReadLine());


            area = 3.14159 / 4 *( diametro * diametro);

       
            Console.Write("a área do círculo área: ");
            Console.WriteLine(area);
        }
    }
}
