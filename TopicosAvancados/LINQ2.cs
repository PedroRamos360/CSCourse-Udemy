using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp.TopicosAvancados {
    class LINQ2 {
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
            var pedro = alunos.Single(aluno => aluno.Nome == "Pedro");
            Console.WriteLine($"O aluno {pedro.Nome} tirou {pedro.Nota}");

            var fulano = alunos.SingleOrDefault(aluno => aluno.Nome == "Fulano");
            if (fulano == null) {
                Console.WriteLine("Aluno Inexistente");
            }

            var ana = alunos.First(aluno => aluno.Nome == "Ana");
            Console.WriteLine($"A aluna {ana.Nome} tirou {ana.Nota}");

            var sicrano = alunos.FirstOrDefault(aluno => aluno.Nota == 5);
            if (sicrano == null) {
                Console.WriteLine("Aluno Inexistente");
            }

            var outraAna = alunos.LastOrDefault(aluno => aluno.Nome == "Ana");
            if (outraAna != null) {
                Console.WriteLine($"A aluna {outraAna.Nome} tirou {outraAna.Nota}");
            }

            var exemploSkip = alunos.Skip(1).Take(3);
            foreach (var aluno in exemploSkip)
                Console.WriteLine(aluno.Nome);

            var maiorNota = alunos.Max(aluno => aluno.Nota);
            Console.WriteLine(maiorNota);

            var menorNota = alunos.Min(aluno => aluno.Nota);
            Console.WriteLine(menorNota);

            var somatorioNotas = alunos.Sum(aluno => aluno.Nota);
            Console.WriteLine(somatorioNotas);

            var mediaNotas = alunos.Average(aluno => aluno.Nota);
            Console.WriteLine(mediaNotas);

        }
    }
}
