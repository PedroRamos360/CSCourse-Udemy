using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturasDeControle {
    class EstruturaSwitch {
        public static void Executar() {
            Console.Write("Avalie o meu atendimento (de 1 a 5): ");
            int.TryParse(Console.ReadLine(), out int nota);

            // switch recebe em vez de bool valores int ou str
            switch (nota) {
                case 1:
                    Console.WriteLine("Péssimo");
                    break; // obrigátorio. Usado para sair da estrutura switch
                // é possível também colocar dois casos com uma mesma resposta
                // case 1:
                // case 2:
                //  (sentença)
                //  break;
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Perfeito");
                    Console.WriteLine(":)");
                    break;
                default: // se nenhum dos casos for correspondido...
                    Console.WriteLine("Nota Inválida");
                    break;
            }
            Console.WriteLine("Obrigado por responder!");
        }
    }
}
