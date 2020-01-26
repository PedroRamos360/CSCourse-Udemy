using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametroPadrao {
        public static int Somar(int a = 1, int b = 1) { // função com valor padrão
            return a + b;
        }
        public static void Executar() {
            Console.WriteLine(Somar(10, 23));
            Console.WriteLine(Somar(50));
            Console.WriteLine(Somar()); // se nada for atribuído é usado o valor padrão
            Console.WriteLine(Somar(b: 7));
        }
    }
}
