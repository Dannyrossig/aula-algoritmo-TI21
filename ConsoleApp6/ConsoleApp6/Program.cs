using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero; // declaração da variavel
            Console.WriteLine("escreva qual numero de usuario "); // escreva na tela
            numero = int.Parse(Console.ReadLine()); // converter de texto para numero para variavel inteiro

            if(numero % 2 == 0) // serve para fazer as verificaçoes gerais
            {
                Console.WriteLine("o numero é par");
            } // entre chaves é o trecho que vai executar caso o if seja verdadeiro ou falso.
            else // caso o if nao seja verdadeiro.
            {
                Console.WriteLine(" o numero é impar");// parenteses ficar de olho no erro vermelhinho
            }
             
                


            Console.ReadKey();// serve para nao fechar o programa, tela preta.


        }// três ultimas chaves nunca apagar.
    }
}
