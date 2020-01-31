using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    class Nullables {
        public static void Executar() {
            Nullable<int> num1 = null;
            int? num2 = null;

            if (num1.HasValue) {
                Console.WriteLine($"Valor de num: {num1}");
            } else {
                Console.WriteLine("A váriavel não possui valor");
            }

            int valor = num2 ?? 1000;
            Console.WriteLine(valor);

            bool? booleano = null;
            bool resultado = booleano.GetValueOrDefault();
            Console.WriteLine(resultado);

            try {
                int x = num1.GetValueOrDefault(1);
                int y = num2.GetValueOrDefault(2);
                Console.WriteLine(x + y);
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
