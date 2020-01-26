using System;
using Encapsulamento;

namespace CursoCSharp.OO {
    public class FilhoDistante : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Filho Distante...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDoOlho);
            Console.WriteLine(JeitoDeFalar);
        }
    }

    public class AmigoDistante {
        public readonly SubCelebridade amiga = new SubCelebridade();
        public void MeusAcessos() {
            Console.WriteLine("Amigo Distante...");

            Console.WriteLine(amiga.InfoPublica);
        }
    }
    class Encapsulamento {
        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoDistante().MeusAcessos();
            new AmigoDistante().MeusAcessos();

        }
    }
}
