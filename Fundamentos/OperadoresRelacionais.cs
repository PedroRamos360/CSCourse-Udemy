using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() {
            Console.Write("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);
            double media = 7.0;
            if (nota <= 10 & nota >= 0) {
                Console.WriteLine("Gabaritou? {0}", nota == 10);
                Console.WriteLine("Pode melhorar? {0}", nota != 10);
                Console.WriteLine("Passou de ano? {0}", nota >= media);
                Console.WriteLine("Recuperação? {0}", nota < media);
                Console.WriteLine("Reprovou? {0}", nota <= 3);
            } else {
                Console.WriteLine("A Nota digitada é inválida");
            }
        }
    }
}
