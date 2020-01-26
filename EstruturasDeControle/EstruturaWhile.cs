using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 21);
            // gera um número de 1 a 15 já que o 16 não é considerado
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            
            while (!numeroEncontrado && tentativasRestantes > 0) {
                Console.Write("Insira seu palpite: ");
                int.TryParse(Console.ReadLine(), out palpite);
                tentativasRestantes--;

                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.Write($"Número encontrado em {5 - tentativasRestantes} tentativas");
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("O valor secreto é menor... Tente novamente");
                    Console.WriteLine($"Tentativas restantes {tentativasRestantes}");
                } else {
                    Console.WriteLine("O valor secreto é maior... Tente novamente");
                    Console.WriteLine($"Tentativas restantes {tentativasRestantes}");
                }
            }
        }
    }
}
