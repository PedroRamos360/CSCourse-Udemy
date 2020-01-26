using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class Break {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next(1, 51); // não considera o 51

            Console.WriteLine("O número que queremos é {0}", numero);

            for (int i = 1; i <= 50; i++) {
                Console.Write($"{i} é o número que queremos? ");
                if (i == numero) {
                    Console.WriteLine("Sim!");
                    break;
                } else {
                    Console.WriteLine("Não!");
                }
            }
            Console.WriteLine("O número foi descoberto com sucesso");
        }
    }
}
