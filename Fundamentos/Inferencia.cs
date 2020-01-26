using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            // se não colocar o tipo da variavél, o C# descobre, isso se chama de inferência
            var nome = "Leonardo";
            // aqui ele identifica como string
            Console.WriteLine(nome);

            // mesma coisa acontece para int
            var idade = 15;
            /* também pode ser escrito como:
             * int idade;
             * idade = 15;
             * obs: não se pode fazer o mesmo se usar o prefixo "var"
             */
            Console.WriteLine(idade);

            int a; // inicializa váriavel
            a = 3; // atribui valor

            int b = 2; // inicializa e atribui valor na mesma linha
            Console.WriteLine(a + b);
        }
    }
}
