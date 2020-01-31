using System;
using System.Collections.Generic;
using CursoCSharp.ClassesEMetodos;
using System.Text;

namespace CursoCSharp.TopicosAvancados {
    public class Caixa<It> { // Classe Genérica porque o It é indefinido, não há como saber o que ele é.
        It valorPrivado;
        public It ACoisa { get; set; }

        public Caixa(It aCoisa) {
            ACoisa = aCoisa;
            valorPrivado = aCoisa;
        }

        public It metodoGenerico(It valor) {
            return new Random().Next(0, 2) == 0 ? ACoisa : valor;
        }

        public It GetValor() {
            return valorPrivado;
        }
    }
    class CaixaInt : Caixa<int> { // No momento da herança que é definido o tipo It
        public CaixaInt() : base(0) {

        }
    }
    class CaixaCalculadora : Caixa<CalculadoraComum> { 
        public CaixaCalculadora() : base(new CalculadoraComum()) {

        }
    }

    class ExemploGenerics {
        public static void Executar() {
            var caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.ACoisa.GetType());

            var caixa2 = new Caixa<string>("C#");
            Console.WriteLine(caixa2.metodoGenerico("Python"));
            Console.WriteLine(caixa2.ACoisa.GetType());

            CaixaCalculadora caixa3 = new CaixaCalculadora();
            Console.WriteLine(caixa3.ACoisa.GetType().Name);
        }
    }
}
