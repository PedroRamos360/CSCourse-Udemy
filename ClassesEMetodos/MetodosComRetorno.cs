using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class CalculadoraComum {
        // Assinatura do método: o que fica dentro dos parenteses
        public int Somar(int a, int b) {
            return a + b;
        }

        public int Subtrair(int a, int b) {
            return a - b;
        }

        public int Multiplicar(int a, int b) {
            return a * b;
        }

        public double Dividir(int a, int b) {
            return a / b;
        }
    }
    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia Multiplicar(int a) {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Escrever() {
            Console.WriteLine(memoria);
            return this;
        }

        public int Resultado() {
            return memoria;
        }

    }

    class MetodosComRetorno {
        public static void Executar() {
            var CalculadoraComum = new CalculadoraComum();
            var resultado = CalculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(CalculadoraComum.Subtrair(7, 9));
            Console.WriteLine(CalculadoraComum.Multiplicar(5, 9));
            Console.WriteLine(CalculadoraComum.Dividir(49, 7));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicar(4).Escrever()
                .Limpar().Escrever();

            CalculadoraCadeia Resultado = calculadoraCadeia.Somar(7).Multiplicar(7).Escrever();
            Console.WriteLine(Resultado);
        }
    }
}
