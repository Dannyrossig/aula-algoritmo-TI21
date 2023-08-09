using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a;
            int b;
            int soma;
            int subtracao;
            int multiplicacao;
            int divisao;
            int resto;


            //Console.Write("Hello Word");

            Console.Write("Digite o 1° numero");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o 2° numero");
            b = int.Parse(Console.ReadLine());

            soma = a + b; //Estamos somandos os valores das variaveis a e b

            Console.WriteLine("A soma dos valores: " + soma); //WriteLine serve para quebrar a minha linha no final

            subtracao = a - b; //Estamos subtraindo os valores das variaveis a e b

            Console.WriteLine(" A subtracao dos valores: " + subtracao);

            multiplicacao = a * b;

            Console.WriteLine(" A multiplicacao dos valores: " + multiplicacao);
            
            divisao = a / b;   
            
            Console.WriteLine(" A divisao dos valores: " + divisao);






            Console.ReadKey();

        }
    }
}
