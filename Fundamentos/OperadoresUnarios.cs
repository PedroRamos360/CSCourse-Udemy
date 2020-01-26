using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresUnarios {
        public static void Executar() {
            var valorNegativo = -5;
            var numero1 = 2;
            var numero2 = 3;
            var booleano = true;

            Console.WriteLine(-valorNegativo); // - inverte o sinal
            Console.WriteLine(!booleano); // ! inverte o valor bool true => false

            numero1++;
            Console.WriteLine(numero1);

            --numero1; // tanto faz --variavel; / variavel--; diferença é a preferência
            Console.WriteLine(numero1);

            Console.WriteLine(numero1++ == --numero2); // código ruim, fica confuso
            /* numero1 tem o sinal de depois dele ou seja
             * tem menos preferência o que faz com que ele seja
             * acrescentado depois da comparação enquanto o 
             * numero2 é diminuido depois da comparação
             * resultado 2 == (3 - 1) => true
             */

            Console.WriteLine($"{numero1} {numero2}");
            /* neste momento numero1 e numero 2 tem valores
             * diferentes, porque depois da comparação o numero1
             * recebeu a soma de 1 totalizando 3
             * resultado: 3 2
             */
        }
    }
}
