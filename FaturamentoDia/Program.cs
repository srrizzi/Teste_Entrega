using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace FaturamentoDia
{
    class Program
    {
        static void Main()
        {
            var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\dados.json");
            var dadosDia = JsonConvert.DeserializeObject<List<Dia>>(json);

            double[] valor = new double[30];

            int i = 0;
            int quantidadeDiasMaiorMedia = 0;
            double valorMinimo = 50000;
            double media;
            double acumulador = 0;
          


            while(i < dadosDia.Count)
            {
                valor[i] = dadosDia[i].valor;
                i++;
            }

            for(i = 0; i < valor.Length; i++)
            {
                if (valor[i] > 0)
                {
                    if (valor[i] < valorMinimo)
                    {
                        valorMinimo = valor[i];
                    }
                }
                
            }

            for(i = 0; i < valor.Length; i++)
            {
                acumulador += valor[i];
            }

            media = acumulador / valor.Length;

            for(i = 0; i < valor.Length; i++)
            {
                if(media > valor[i])
                {
                    quantidadeDiasMaiorMedia++;
                }
            }

            Console.WriteLine($"O menor valor de faturamento foi de R${valorMinimo.ToString("F2", CultureInfo.InvariantCulture)}.");
            Console.WriteLine($"O maior valor de faturamento foi de R${valor.Max().ToString("F2", CultureInfo.InvariantCulture)}.");
            Console.WriteLine($"A quantidade de dias, com o valor de faturamento maior que a média, foram {quantidadeDiasMaiorMedia} dias.");
            Console.ReadKey();
        }
    }
}
