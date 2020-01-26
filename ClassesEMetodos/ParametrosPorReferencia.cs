using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosPorReferencia {
        public static void AlterarRef(ref int numero) { // ref: recebe apenas váriavel setada
            numero = numero + 1000;
        }

        public static void AlterarOut(out int numero) { // out: não recebe váriavel setada
            numero = 0;
            numero = numero + 15;
        }
        public static void Executar() {
            int a = 3;
            AlterarRef(ref a);
            Console.WriteLine(a);

            //int b;
            //AlterarOut(out b);
            //Console.WriteLine(b);
            // ou
            AlterarOut(out int b);
            Console.WriteLine(b);
        }
    }
}
