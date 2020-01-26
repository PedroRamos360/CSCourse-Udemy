using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string nome = "Notebook Gamer";
            string marca = "Dell";
            double preco = 5800.00;

            // código BURRO
            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            // código INTELIGENTE
            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, preco);

            // código GENIAL
            Console.WriteLine($"O {nome} da marca {marca} custa {preco}.");

            // código MATEMATICAMENTE GENIAL
            Console.WriteLine($"1 + 1 = {1 + 1}!");
        }
    }
}
