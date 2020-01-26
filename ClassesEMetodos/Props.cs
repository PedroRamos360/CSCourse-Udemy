using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class CarroOpcional {
        double desconto = 10;

        string nome;
        public string Nome {
            get {
                return "Opcional: " + nome; // para ler valor
            }
            set {
                nome = value; // altera o valor de nome
            }
        }
        // Propriedade autoimplementada
        public double Preco { get; set; }

        // Somente leitura
        public double PrecoComDesconto {
            get => Preco - (Preco * (desconto / 100)); // notação Lambda
            // ou
            // get {
            //  return Preco - (Preco * (desconto / 100));
            // }
        }

        public CarroOpcional() {
            
        }

        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }
    }
    class Props {
        public static void Executar() {
            var op1 = new CarroOpcional("Ar condicionado", 3499.99);
            Console.WriteLine(op1.PrecoComDesconto.ToString("F2"));

            var op2 = new CarroOpcional();
            op2.Nome = "Direção Elétrica";
            op2.Preco = 2349.99;

            Console.WriteLine(op1.Nome);
            Console.WriteLine(op1.Preco);

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        }
    }
}
