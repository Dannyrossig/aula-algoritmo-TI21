using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float pagamento, valor, troco;

            Console.WriteLine("digite o valor total da compra: ");
            valor = float.Parse(Console.ReadLine());

            Console.WriteLine("digite o valor pelo Cliente: ");
            pagamento = float.Parse(Console.ReadLine());

            troco = pagamento - valor;

            Console.WriteLine("o valor do seu troco é: " + troco);



            Console.ReadKey();







        }
    }
}
