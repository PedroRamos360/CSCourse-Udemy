using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatandoNumeros {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F1"));
            // F arredonda o número
            // resultado 15,2

            Console.WriteLine(valor.ToString("C"));
            // C transforma em valor monetário
            // resultado R$ 15,18

            Console.WriteLine(valor.ToString("P"));
            // P transforma em porcentagem, multiplica por cem
            // resultado 1.517,50%

            Console.WriteLine(valor.ToString("#.##"));
            // # igual ao F, nesse caso seria F2
            // resultado 15,18

            CultureInfo cultura = new CultureInfo("en-US");
            // pega informações da cultura de determinado país
            // no caso os EUA representado por en-US

            Console.WriteLine(valor.ToString("C", cultura));
            // resultado fica, portanto, em dólares e com ponto $15.18

            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
            // formata o número de forma que ele tenha dez dígitos
            // resultado 0000000256
        }
    }
}
