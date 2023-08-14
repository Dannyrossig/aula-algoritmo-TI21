using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float a, b,c;
            float soma, media;

            Console.WriteLine(" digite numero a"); //Estamos somandos os valores das variaveis a e b e c
            a = int.Parse(Console.ReadLine());
            Console.WriteLine(" digite numero b");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine(" digite numero c");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine(" leia resultado da média");
            media = (a+b+c) / 3;
            Console.WriteLine(" o resultado da media é: " + media);






















            Console.ReadKey();
        }
    }
}
