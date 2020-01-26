using System;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaIf {
        public static void Executar() {
            bool bomComportamento;
            string entrada;

            Console.Write("Digite o nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.Write("Possui bom comportamento (S/N): ");
            entrada = Console.ReadLine();

            entrada = entrada.ToLower();
            entrada = entrada.Trim();

            // CÓDIGO BURRO:
            //if (entrada == "s") {
            //    bomComportamento = true;
            //} else {
            //    bomComportamento = false;
            //}

            // CÓDIGO OTIMIZADO:
            bomComportamento = entrada == "s";
            bomComportamento = entrada == "s";

            if (nota >= 9.0 && bomComportamento) {
                Console.WriteLine($"{nome} passou de ano e entrou para o quadro de honra");
            } else {
                if (bomComportamento) {
                    nota++;
                } else {
                    nota--;
                }

                if (nota >= 7) {
                    Console.WriteLine($"{nome} passou de ano");
                } else {
                    Console.WriteLine($"{nome} não passou de ano");
                }
            }
        }
    }
}
