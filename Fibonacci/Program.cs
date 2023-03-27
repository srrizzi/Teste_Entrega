using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int a = 0, b = 1, c;

            while(b < numero)
            {
                c = a + b;
                a = b;
                b = c;
            }

            if(b == numero)
            {
                Console.WriteLine($"O {numero} pertence a sequencia de Fibonacci");
            }
            else
            {
                Console.WriteLine($"O {numero} não pertence a sequencia de Fibonacci");
            }

            Console.ReadKey();
        }
    }
}
