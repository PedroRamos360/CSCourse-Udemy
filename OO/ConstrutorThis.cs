using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    public class Animal {
        public string Nome { get; set; }

        public Animal(string nome) {
            Nome = nome;
        }
    }

    public class Doggo : Animal { 
        public double Altura { get; set; }

        public Doggo(string nome) : base(nome) {
            Console.WriteLine($"Doggo {nome} inicializado");
        }

        public Doggo(string nome, double altura) : this(nome) {
            Altura = altura;
        }

        public override string ToString() {
            return $"{Nome} tem {Altura}cm de altura";
        }
    }
    class ConstrutorThis {
        public static void Executar() {
            var laika = new Doggo("Laika", 40);
            var clarinha = new Doggo("Clarinha", 25.0);

            Console.WriteLine(laika);
            Console.WriteLine(clarinha);
        }
    }
}
