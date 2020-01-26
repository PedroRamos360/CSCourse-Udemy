using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // área da circunferência
            double raio = 4.5; // MUTÁVEL
            const double PI = 3.14; // IMUTÁVEL, graças ao "const"

            raio = 5.5; // => CERTO
            // PI = 3.1415 => ERRADO
            double area = 2 * PI * raio * raio;
            Console.WriteLine("A Área da circunferência é " + (area + 10));
            // Lembrar de colocar entre parenteses, se não concatena => string + area + 10

            // Tipos internos

            bool estaChovendo = true;
            Console.WriteLine("Está chovendo: " + estaChovendo);

            /* tipos numéricos:
             * byte: 1 byte => 8 bits
             * short: 2 bytes => 16 bits
             * int: 4 bytes => 32 bits
             * long: 8 bytes => 64 bits
             */

            byte idade = 45;
            Console.WriteLine("Idade: " + idade);

            sbyte saldoDeGols = sbyte.MaxValue;
            Console.WriteLine(saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine(salario);

            int pequeno = int.MinValue;
            Console.WriteLine(pequeno);

            int grande = int.MaxValue;
            Console.WriteLine(grande);

            uint populacaoBR = 207_600_000;
            Console.WriteLine("População Brasileira: " + populacaoBR);

            long menorValor = long.MinValue;
            Console.WriteLine("menorLong" + menorValor);

            ulong populacaoGlobal = 7_600_000_000;
            Console.WriteLine("População Global: " + populacaoGlobal);


            /* tipos com casas decimais:
             * float: 4 bytes
             * double: 8 bytes
            */

            // arrisca perda de dados por isso necessita o "f"
            float precoComputador = 1299.995124112f; 
            Console.WriteLine(precoComputador);
 
            // não arrisca perda de dados e é a forma mais usada para reais
            double valorDeMercadoDaApple = 1_503_601_200_030_051.01;
            Console.WriteLine("Valor Apple: " + valorDeMercadoDaApple);

            decimal distanciaEstrelas = decimal.MaxValue;
            Console.WriteLine(distanciaEstrelas);

            /* caracteres:
             * char: para caracteres únicos
             * string: para cadeias de caracteres
             */

            // aspas simples caracteres únicos
            char letra = 'b';
            Console.WriteLine("Letra" + letra);

            // aspas duplas para cadeias de caracteres
            string texto = "Curso de C#";
            Console.WriteLine(texto);
        }
    }
}
