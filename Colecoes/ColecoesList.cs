using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    public class Produto {
        public string Nome;
        public double Preco;

        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object obj) {
            return obj is Produto produto &&
                   Nome == produto.Nome &&
                   Preco == produto.Preco;
        }

        public override int GetHashCode() {
            return HashCode.Combine(Nome, Preco);
        }
    }
    class ColecoesList { // Aceita repetição
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.99);

            var carrinho = new List<Produto>();
            carrinho.Add(livro);

            var combo = new List<Produto> {
                    new Produto("Camiseta", 29.99),
                    new Produto("Action Figure", 99.99),
                    new Produto("Poster", 5),
                };

            carrinho.AddRange(combo); // para adicionar todos os itens de uma lista
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(3);

            foreach(var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome}, {item.Preco}");
            }
        }
    }
}
