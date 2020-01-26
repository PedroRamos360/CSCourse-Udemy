using System;

namespace CursoCSharp.ClassesEMetodos {
    class Membros {
        public static void Executar() {
            // CÓDIGO BURRO
            Pessoa sicrano = new Pessoa();
            sicrano.Nome = "Pedro";
            sicrano.Idade = 15;

            // .ApresentarNoConsole apenas apresenta no console
            sicrano.ApresentarNoConsole();
            sicrano.Zerar();
            sicrano.ApresentarNoConsole();

            // CÓDIGO INTELIGENTE
            var fulano = new Pessoa(); // pode ser usado var em vez do nome da classe
            fulano.Nome = "Beto";
            fulano.Idade = 37;

            // Enquanto com .Apresentar podem ser realizadas diversas funções
            var apresentacaoDoFulano = fulano.Apresentar();
            Console.WriteLine($"Comprimento da frase: {apresentacaoDoFulano.Length} caracteres");
            Console.WriteLine(apresentacaoDoFulano.ToLower());
        }
    }
}
