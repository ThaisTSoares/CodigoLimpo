using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoLimpo
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Unid.: ");
            System.Console.WriteLine(NumeroParaString.unidadeParaTexto(1));
            System.Console.Write("Dez.: ");
            System.Console.WriteLine(NumeroParaString.dezenaParaTexto(15));
           System.Console.ReadKey();
        }
    }
}
