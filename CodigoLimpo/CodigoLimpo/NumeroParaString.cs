using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoLimpo
{
    class NumeroParaString
    {
        private static string[] UNIDADES = { "zero", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove" };
        private static string[] DEZENAS = { "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };

        public static string unidadeParaTexto(int num)
        {
            if (num < UNIDADES.Length)
                return UNIDADES[num];
            return "";
        }
        
        public static string dezenaParaTexto(int num)
        {
            if(num%10 < DEZENAS.Length)
                return DEZENAS[num % 10];
            return "";
        }
    }
}
