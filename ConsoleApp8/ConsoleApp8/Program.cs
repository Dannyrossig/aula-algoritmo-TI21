using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura;
            double imc;



            Console.WriteLine("Qual seu peso: ");
            peso = float.Parse(Console.ReadLine());



            Console.WriteLine("Qual a sua altura: ");
            altura = float.Parse(Console.ReadLine());



            imc = peso / Math.Pow(altura, 2);



            if (imc < 18.5)
            {
                Console.WriteLine("classificação: MAGREZA");



            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("Classificação: NORMAL");



            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("Classificação: SOBREPESO");
            }
            else if (imc <= 34.9)
            {
                Console.WriteLine("Classificação: OBESIDADE GRAU 1");
            }
            else if (imc <= 39.9)
            {
                Console.WriteLine("Classificação: OBESIDADE GRAU 2");
            }
            else
            {
                Console.WriteLine("Classificação: OBESIDADE GRAU 3");
            }





















            Console.ReadKey();
        }
    }
}
