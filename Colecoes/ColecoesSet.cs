using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesSet { // sem repetição
        public static void Executar() {
            var livro = new Produto("Game of Thrones", 49.99);

            var carrinho = new HashSet<Produto>(); // sem index
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                    new Produto("Camiseta", 29.99),
                    new Produto("Action Figure", 99.99),
                    new Produto("Poster", 5),
                    new Produto("Poster", 5),
                    livro,
                };

            carrinho.UnionWith(combo);
            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            foreach(var item in carrinho) {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome}, {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            //Console.WriteLine(carrinho.LastIdexOf(livro));
        }
    }
}
