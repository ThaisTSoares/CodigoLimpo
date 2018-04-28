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
        private static string[] DEZ_A_DEZENOVE = { "dez", "onze", "doze", "treze", "quatorze", "quinze", "dezesseis", "dezessete", "dezoito", "dezenove" };
        private static string[] DEZENAS = { "", "dez", "vinte", "trinta", "quarenta", "cinquenta", "sessenta", "setenta", "oitenta", "noventa" };
        private static string[] CENTENAS = { "cem", "cento", "duzentos", "trezentos", "quatrocentos", "quinhetos", "seiscentos", "setecentos", "oitocentos", "novecentos" };

        public static string unidadeParaTexto(int num)
        {
            if (num < UNIDADES.Length)
                return UNIDADES[num];
            return "";
        }

        public static string dezenaParaTexto(int num)
        {
            if (num < 10)
                return unidadeParaTexto(num);

            if (num < 20)
            {
                if (num % 10 < DEZ_A_DEZENOVE.Length)
                    return DEZ_A_DEZENOVE[num % 10];
                return "";
            }

            return DEZENAS[num / 10] + ((num % 10 != 0) ? " e " + unidadeParaTexto(num % 10) : "");
        }

        public static string centenaParaTexto(int num)
        {
            if (num == 100)            
                return CENTENAS[0];

            return CENTENAS[num / 100] + ((num % 100 != 0) ? " e " + dezenaParaTexto(num % 100) : "");
        }
    }
}
