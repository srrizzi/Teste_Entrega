using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FaturamentoMensal
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            double sp = 67836.43;
            double rj = 36678.66;
            double mg = 29229.88;
            double es = 27165.48;
            double outros = 19849.53;

            double total = sp + rj + mg + es + outros;
            
            sp = (100 * sp) / total;
            rj = (100 * rj) / total;
            mg = (100 * mg) / total;
            es = (100 * es) / total;
            outros = (100 * outros) / total;
            
            Console.WriteLine("O estado de SP uma porcentagem de " + sp.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O estado de RJ uma porcentagem de " + rj.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O estado de MG uma porcentagem de " + mg.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("O estado de ES uma porcentagem de " + es.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Outros estados tem uma porcentagem de " + outros.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}
