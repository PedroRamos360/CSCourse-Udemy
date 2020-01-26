using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    public class Cliente {
        public string Nome;
        readonly DateTime Nascimento; // para setar valores imútaveis
        // não é necessário dar valor pra ele no primeiro momento diferente do const

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataNascimento() {
            return String.Format("{0}/{1}/{2}",
                Nascimento.Day.ToString("D2"), Nascimento.Month.ToString("D2"), Nascimento.Year);
        }
    }
    class Readonly {
        public static void Executar() {
            var NovoCliente = new Cliente("Pedro Ramos", new DateTime(2004, 5, 4));

            Console.WriteLine(NovoCliente.Nome);
            Console.WriteLine(NovoCliente.GetDataNascimento());

        }
    }
}
