using System;

namespace CursoCSharp.Fundamentos {
    class OperadoresAtribuicao {
        public static void Executar() {
            int num1 = 3;
            num1 = 7; // substitui a váriavel
            num1 += 10; // soma 10 da váriavel
            num1 -= 3; // subtrai 3 da váriavel
            num1 *= 5; // multiplica 5 da váriavel
            num1 /= 2; // divide 2 da váriavel

            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // => a = a + 1;
            b--; // => b = b - 1;

            Console.WriteLine($"{a} {b}");

            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";

            dynamic d = c;
            d.nome = "Maria";

            Console.WriteLine($"{c.nome}");
        }
    }
}
