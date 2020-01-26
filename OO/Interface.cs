using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    interface OperacaoBinaria { // Todos os métodos são públicos e abstratos
        int Operacao(int a, int b);
    }

    class Soma : OperacaoBinaria { // sempre que for herdado é obrigatório chamar TODOS os métodos herdados
        public int Operacao(int a, int b) { // <==========
            return a + b;
        }
    }

    class Subtracao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a - b;
        }
    }
    class Multiplicacao : OperacaoBinaria {
        public int Operacao(int a, int b) {
            return a * b;
        }
    }

    class Calculadora {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria> {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),
        };

        public string ExecutarOperacoes(int a, int b) {
            string resultado = "";

            foreach(var operacao in operacoes) {
                resultado += $"Usando {operacao.GetType().Name} = {operacao.Operacao(a, b)}\n";
            }
            return resultado;
        }
    }
    class Interface {
        public static void Executar() {
            var calc = new Calculadora();
            var resultado = calc.ExecutarOperacoes(20, 5);
            Console.WriteLine(resultado);
        }
    }
}
