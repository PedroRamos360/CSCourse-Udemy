using System;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIfElseIf {
        public static void Executar() {
            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a nota do aluno: ");
            double.TryParse(Console.ReadLine(), out double nota);

            if (nota >= 0 && nota <= 10) {
                if (nota >= 9) {
                    Console.WriteLine($"{nome} foi aprovado e entrou para o quadro de honra!");
                } else if (nota >= 7) {
                    Console.WriteLine($"{nome} foi aprovado!");
                } else if (nota >= 5) {
                    Console.WriteLine($"{nome} pegou recuperação");
                } else {
                    Console.WriteLine($"{nome} foi reprovado");
                }
            } else {
                Console.WriteLine("Nota inválida");
            }
        }
    }
}
