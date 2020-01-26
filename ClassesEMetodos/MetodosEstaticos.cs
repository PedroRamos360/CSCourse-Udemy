using System;

namespace CursoCSharp.ClassesEMetodos {
    class MetodosEstaticos {
        public class CalculadoraEstatica {
            // Método de Classe ou método estático
            public static int Somar(int a, int b) {
                return a + b;
            }
            // Método de Instancia / objeto
            public int Multiplicar(int a, int b) {
                return a * b;
            }
        }
        public static void Executar() {
            Console.WriteLine(CalculadoraEstatica.Somar(5040, -80));

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Multiplicar(5040, 5040));
        }
    }
}
