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

        public static string unidadeParaTexto(int num)
        {
            if(num < UNIDADES.Length)
                return UNIDADES[num];
            return "";
        }
    }
}
