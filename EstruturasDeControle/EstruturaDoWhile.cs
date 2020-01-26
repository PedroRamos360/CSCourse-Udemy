using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaDoWhile {
        public static void Executar() {
            string entrada;

            // A estrutura do while é a única que exige ; no final dela
            do {
                Console.Write("Qual o seu nome? ");
                entrada = Console.ReadLine();

                Console.WriteLine($"Seja bem vindo {entrada}!");
                Console.Write("Deseja continuar?(S/N) ");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}
