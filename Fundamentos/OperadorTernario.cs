using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadorTernario {
        public static void Executar() {
            Console.Write("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            Console.Write("Bom comportamento? ");
            string comportamento = Console.ReadLine();

            comportamento = comportamento.ToLower();
            comportamento = comportamento.Trim();

            if (comportamento == "sim") {
                nota++;
            } else {
                nota--;
            }

            if (nota >= 0 && nota <= 10) {
                var resultado = nota >= 7.0 ? "Aprovado" : "Reprovado"; // ? if : else
                // ? para verdadeiro : para falso
                Console.WriteLine(resultado);
            } else {
                Console.WriteLine("Nota Inválida");
            }
        }
    }
}
