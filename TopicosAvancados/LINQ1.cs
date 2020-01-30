using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    public class Aluno {
        public string Nome;
        public int Idade;
        public double Nota;
    }
    class LINQ1 {
        public static void Executar() {
            var alunos = new List<Aluno> {
                new Aluno() { Nome = "Pedro", Idade = 15, Nota = 10 },
                new Aluno() { Nome = "Andre", Idade = 16, Nota = 4.3 },
                new Aluno() { Nome = "Ana", Idade = 16, Nota = 0.1 },
                new Aluno() { Nome = "Jorge", Idade = 17, Nota = 6.3 },
                new Aluno() { Nome = "Ana", Idade = 16, Nota = 9 },
                new Aluno() { Nome = "Júlia", Idade = 16, Nota = 6.9 },
                new Aluno() { Nome = "Marcio", Idade = 15, Nota = 9.8 },
            };

            Console.WriteLine("================== Aprovados ==================");
            var aprovados = alunos.Where(aluno => aluno.Nota >= 7).OrderBy(aluno => -aluno.Nota);
            foreach (var aluno in aprovados) {
                Console.WriteLine($"{aluno.Nome}: {aluno.Nota}"); // Maior nota pra menor
            }

            Console.WriteLine("\n================== Chamada ==================");
            var chamada = alunos.OrderBy(aluno => aluno.Nome) // Ordem por nome
                .Select(aluno => aluno.Nome); // para mostrar apenas o nome do aluno
            foreach (var aluno in chamada) {
                Console.WriteLine(aluno);
            }

            Console.WriteLine("\n================== Aprovados (Por Idade) ==================");
            var alunosAprovados =
                from aluno in alunos
                where aluno.Nota >= 7
                orderby aluno.Idade
                select aluno.Nome;

            foreach (var aluno in alunosAprovados) {
                Console.WriteLine(aluno);
            }

        }
    }
}
