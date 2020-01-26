using System;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaFor {
        public static void Executar() {
            // for é dividido em três partes:
            // definição da váriavel => int i = 1;
            // definição da condição => i <= 10;
            // definição do incremento => i++
            // resultado:
            //for (int i = 0; i < 10; i++) {
            //    (Senteça que será repetida)

            double somatorio = 0;

            Console.Write("Informe o tamanho da turma: ");
            int.TryParse(Console.ReadLine(), out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.Write("Informe a nota do aluno {0}: ", i);
                double.TryParse(Console.ReadLine(), out double nota);
                if (nota <= 10 && nota >= 0) {
                    somatorio += nota;
                } else {
                    Console.WriteLine("Nota inválida");
                    i--;
                }
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da turma {0}", media);
        }
    }
}

