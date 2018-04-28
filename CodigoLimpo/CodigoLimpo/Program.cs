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
            System.Console.Write("Dez.: ");
            System.Console.WriteLine(NumeroParaString.dezenaParaTexto(50));
            System.Console.Write("Dez.: ");
            System.Console.WriteLine(NumeroParaString.dezenaParaTexto(61));
            System.Console.Write("Cent.: ");
            System.Console.WriteLine(NumeroParaString.centenaParaTexto(100));
            System.Console.Write("Cent.: ");
            System.Console.WriteLine(NumeroParaString.centenaParaTexto(101));
            System.Console.Write("Cent.: ");
            System.Console.WriteLine(NumeroParaString.centenaParaTexto(120));
            System.Console.Write("Cent.: ");
            System.Console.WriteLine(NumeroParaString.centenaParaTexto(135));
           System.Console.ReadKey();
        }
    }
}
