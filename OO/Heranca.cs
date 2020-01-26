using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    public class Carro {
        protected readonly double VelocidadeMaxima;
        double VelocidadeAtual;

        public Carro(double velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected double AlterarVelocidade(double delta) {
            double novaVelocidade = VelocidadeAtual + delta;
            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }

            return VelocidadeAtual;
        }

        public virtual double Acelerar(double tempoSegundos) { // virtual = pode ser sobrescrito
            return AlterarVelocidade(5 * Math.Log(tempoSegundos, 2));
        }

        public double Frear(double tempoSegundos) {
            return AlterarVelocidade(-5 * Math.Log(tempoSegundos, 2));
        }

    }

    public class Uno : Carro {
        public Uno() : base(200) {

        }
    }

    public class Ferrari: Carro {
        public Ferrari() : base(350) {

        }

        // Sobrescreve o método pai
        public override double Acelerar(double tempoSegundos) {
            return AlterarVelocidade(15 * Math.Log(tempoSegundos, 2));
        }

        // Oculta o método pai
        public new double Frear(double tempoSegundos) {
            return AlterarVelocidade(-15 * Math.Log(tempoSegundos, 2));
        }
    }

    class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno...");

            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar(4));
            Console.WriteLine(carro1.Acelerar(16));
            Console.WriteLine(carro1.Frear(4));
            Console.WriteLine(carro1.Frear(4));
            Console.WriteLine(carro1.Frear(4));

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar(4));
            Console.WriteLine(carro2.Acelerar(16));
            Console.WriteLine(carro2.Frear(4));
            Console.WriteLine(carro2.Frear(4));
            Console.WriteLine(carro2.Frear(4));

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari(); 
            Console.WriteLine(carro3.Acelerar(4));
            Console.WriteLine(carro3.Acelerar(4));
            Console.WriteLine(carro3.Frear(4));
            Console.WriteLine(carro3.Frear(4));
            Console.WriteLine(carro3.Frear(4));

            Console.WriteLine("Uno com tipo Carro...");
            carro3 = new Uno(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar(4));
            Console.WriteLine(carro3.Acelerar(4));
            Console.WriteLine(carro3.Frear(4));
            Console.WriteLine(carro3.Frear(4));
            Console.WriteLine(carro3.Frear(4));

        }
    }
}
