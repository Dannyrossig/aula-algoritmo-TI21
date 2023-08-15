using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("Qual idade vc tem?");
            numero = int.Parse(Console.ReadLine());

            if (numero >=  18)
            {
                Console.WriteLine(" de maior");

            }
                
                else
            {
                Console.WriteLine(" de menor");

            }
           







                Console.ReadKey();  

        }
    }
}
