using System;

namespace CursoCSharp.EstruturasDeControle {
    class Continue {
        public static void Executar() {
            Console.Write("Digite um intervalo: ");
            int.TryParse(Console.ReadLine(), out int intervalo);

            Console.WriteLine("Números pares entre 1 e {0}", intervalo);
            
            for (int i = 1; i <= intervalo; i++) {
                if (i % 2 == 1) {
                    continue; // não executa o resto dos comandos mas continua repetindo
                }

                Console.Write(i + " ");
            }
        }
    }
}
