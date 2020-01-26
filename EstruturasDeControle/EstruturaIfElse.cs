using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElse {
        public static void Executar() {
            double nota = 7;

            if (nota >= 7) {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que a obrigação...");
            } else {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
