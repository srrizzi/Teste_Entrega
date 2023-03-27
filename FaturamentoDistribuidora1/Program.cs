using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FaturamentoDistribuidora1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDocumento = new XmlDocument();
            xmlDocumento.Load(@"C:\\Users\\carlo\\OneDrive\\Documentos\\Teste Trabalhos\\dados.xml");

            XmlNodeList listas = xmlDocumento.SelectNodes(@"C:\\Users\\carlo\\OneDrive\\Documentos\\Teste Trabalhos\\dados.xml");

            string valor;

            foreach(XmlNode lista in listas)
            {
                valor = lista.InnerText;
            }

            Console.WriteLine(valor);
            Console.ReadKey();
        }

    }
}
