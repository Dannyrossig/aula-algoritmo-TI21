using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float ano;
            Console.WriteLine(" selecione um ano para descobrir se ele é bissexto");
            ano = float.Parse(Console.ReadLine());

            if (ano % 4 == 0) 
            {
                if (ano % 100 != 0) 
                {
                    Console.WriteLine("esse ano é bissexto !");
                } else if (ano % 400 ==  0) 
                {
                    Console.WriteLine("esse ano é bissexto !");
                } else { 
                 Console.WriteLine(" esse ano nao é bissexto !"); 
                }
               

                
            
            
            }else
            {
                Console.WriteLine(" esse ano nao é bissexto !");
            }


            Console.ReadKey();
        }
    }
}
