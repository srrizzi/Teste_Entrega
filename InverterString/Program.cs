using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InverterString
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Digite alguma palavra: ");
            string palavra = Console.ReadLine();

            string inverta = palavra.Inverter();
            Console.WriteLine(inverta);
            Console.ReadLine();
        }
    }

    public static class TesteInverter
    {
        public static string Inverter(this string letra)
        {
            char[] letras = letra.ToCharArray();

            for (int i = 0; i < letra.Length / 2; i++)
            {
                char x = letras[i];
                letras[i] = letras[letra.Length - i - 1];
                letras[letra.Length - i - 1] = x;
            }

            return new string(letras);
        }

    }
}
