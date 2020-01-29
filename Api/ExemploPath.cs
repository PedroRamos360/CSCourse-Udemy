using System;
using System.IO;


namespace CursoCSharp.Api {
    class ExemploPath {
        public static void Executar() {
            var arquivo = @"~/exemplo_path_arquivo.txt".ParseHome();
            var pasta = @"~/exemplo_path_pasta.txt".ParseHome();

            if (!File.Exists(arquivo)) {
                using (StreamWriter sw = File.CreateText(arquivo)) {
                    Console.WriteLine("Novo arquivo criado");
                }
            }

            if (!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }

            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.GetDirectoryName(arquivo));
            Console.WriteLine(Path.HasExtension(arquivo));

            Console.WriteLine(Path.HasExtension(pasta));
            Console.WriteLine(Path.GetFullPath(pasta));
            Console.WriteLine(Path.GetPathRoot(pasta));

            if (File.Exists(arquivo)) {
                File.Delete(arquivo);
            }

            if (Directory.Exists(pasta)) {
                Directory.Delete(pasta);
            }
        }
    }
}
