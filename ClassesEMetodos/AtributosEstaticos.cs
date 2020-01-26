using System;

namespace CursoCSharp.ClassesEMetodos {
    class AtributosEstaticos {
        public class Produto {
            public string Nome;
            public double Preco;
            public double Desconto = 10; // Para descontos únicos de cada produto
            // public static double Desconto = 0.9;  Desconto para todos produtos

            public Produto(string nome, double preco, double desconto) {
                Nome = nome;
                Preco = preco;
                Desconto = desconto;
            }

            public Produto() {

            }

            public double CalcularDesconto() {
                return Preco - (Preco * (Desconto/100));
            }
        }
        public static void Executar() {
            var produto1 = new Produto("Caneta", 5.5, 10);
            var produto2 = new Produto() {
                Nome = "Borracha",
                Preco = 2.3,
                Desconto = 90 // O GERENTE FICOU MALUCO
            };

            Console.WriteLine("O preço da {0} é {1}", produto1.Nome, produto1.CalcularDesconto());
            Console.WriteLine("O preço da {0} é {1}", produto2.Nome, produto2.CalcularDesconto());

        }
    }
}
