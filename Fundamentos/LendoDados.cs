using System;
// para usar . como separador de casas decimais
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            // FAZENDO INPUTS:
            Console.Write("Qual é o seu nome? "); // Faz a pergunta
            string nome = Console.ReadLine(); // Armazena a resposta

            Console.Write($"Olá {nome}, qual é a sua idade? ");
            // transformar texto em string => int.Parse
            int idade = int.Parse(Console.ReadLine());

            if (idade > 18) {
                Console.WriteLine("Você é velho, em!");

                Console.WriteLine("Quanto você ganha? (0 para desempregado)");
                Console.Write("R$ ");
                double salario = double.Parse(Console.ReadLine(),
                    CultureInfo.InvariantCulture); // vai usar símbolos globais não os da maquina

                if (salario == 0) {
                    Console.WriteLine("Mas que vagabundo!");
                }

                if (salario > 2000) {
                    Console.WriteLine($"{salario} é bastante dinheiro!");
                }

                if (salario < 2000) {
                    Console.WriteLine($"{salario} é pouco dinheiro!");
                }

            }

            if (idade <= 18) {
                Console.WriteLine("Mas que jovem!");

                Console.Write("Você já trabalha? ");
                string resposta = Console.ReadLine();
                resposta = resposta.ToLower();
                resposta = resposta.Trim();

                if (resposta == "sim") {
                    Console.WriteLine("Você está no caminho certo!");
                } else {
                    Console.WriteLine("Então foco nos estudos!");
                }
            }
        }
    }
}
