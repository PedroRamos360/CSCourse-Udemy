using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    public class Comida {
        public double Peso;

        public Comida(double peso) {
            Peso = peso;
        }

        public Comida() { }
    }
    public class Arroz : Comida {
        public Arroz(double peso) : base() { }
    }
    public class Feijao : Comida {
        public Feijao(double peso) : base() { }
    }
    public class Batata : Comida {
        public Batata(double peso) : base() { }
    }
    public class Pessoa {
        public double peso;

        public void Comer(Comida comida) {
            peso += comida.Peso;
        }

    }

    class Polimorfismo {
        public static void Executar() {
            Arroz ingrediente1 = new Arroz(.25);

            Feijao ingrediente2 = new Feijao(.3);
   
            Batata ingrediente3 = new Batata(.55);

            Pessoa cliente = new Pessoa();
            cliente.peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);
            Console.WriteLine($"Agora o peso do cliente é {cliente.peso}kg");
        }
    }
}
