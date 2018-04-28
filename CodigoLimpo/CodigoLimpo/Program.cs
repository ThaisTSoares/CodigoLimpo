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
            System.Console.WriteLine(NumeroParaString.numeroParaTexto("1,10"));
            System.Console.Write("Dez.: ");
            System.Console.WriteLine(NumeroParaString.numeroParaTexto("15"));
            System.Console.Write("Dez.: ");
            System.Console.WriteLine(NumeroParaString.numeroParaTexto("50"));
            System.Console.Write("Dez.: ");
            System.Console.WriteLine(NumeroParaString.numeroParaTexto("61"));
            System.Console.Write("Cent.: ");
            System.Console.WriteLine(NumeroParaString.numeroParaTexto("100"));
            System.Console.Write("Cent.: ");
            System.Console.WriteLine(NumeroParaString.numeroParaTexto("101"));
            System.Console.Write("Cent.: ");
            System.Console.WriteLine(NumeroParaString.numeroParaTexto("120"));
            System.Console.Write("Cent.: ");
            System.Console.WriteLine(NumeroParaString.numeroParaTexto("110"));
            System.Console.Write("Mil.: ");
            System.Console.WriteLine(NumeroParaString.numeroParaTexto("2132,45"));

           System.Console.ReadKey();
        }
    }
}
