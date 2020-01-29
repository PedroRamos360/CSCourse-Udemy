using System;
using System.IO;


namespace CursoCSharp.Api {
    class Diretorios {
        public static void Executar() {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"C:\Users\User\source\repos\CursoCSharp\CursoCSharp";
            
            if (Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true); // true para excluir de forma recursiva
            }

            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("=============== Pastas ===============");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
                Console.WriteLine(pasta);

            Console.WriteLine("\n\n=============== Arquivos ===============");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos)
                Console.WriteLine(arquivo);

            Console.WriteLine("\n\n=============== Raíz ===============");
            Console.WriteLine(Directory.GetDirectoryRoot(dirProjeto));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
