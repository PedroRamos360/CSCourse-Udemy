using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class Dependente {
        public string Nome;
        public int Idade;
    }
    class ValorVSReferencia {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;

            Console.WriteLine($"{numero}, {copiaNumero}");

            numero++;
            Console.WriteLine($"{numero}, {copiaNumero}");

            Dependente dep = new Dependente {
                Nome = "Beto",
                Idade = 20
            };

            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Idade}, {copiaDep.Idade}");
            Console.WriteLine($"{dep.Nome}, {copiaDep.Nome}");

            copiaDep.Nome = "Beta";
            dep.Idade = 21;

            Console.WriteLine($"{dep.Idade}, {copiaDep.Idade}");
            Console.WriteLine($"{dep.Nome}, {copiaDep.Nome}");
        }
    }
}
