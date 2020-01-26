using System;

namespace CursoCSharp.Fundamentos {
    class OperadoresLogicos {
        public static void Executar() {
            bool trabalho1 = true;
            bool trabalho2 = false;

            // true se as duas forem true
            bool comprouTv50 = trabalho1 && trabalho2;
            Console.WriteLine($"Comprou Tv50? {comprouTv50}");

            // true se qualquer uma delas for true
            bool comprouSorvete = trabalho1 || trabalho2;
            Console.WriteLine($"Comprou sorevete? {comprouSorvete}");

            // true se apenas uma delas for true
            bool comprouTv32 = trabalho1 ^ trabalho2;
            Console.WriteLine($"Comprou Tv32? {comprouTv32}");

            // true se for false
            Console.WriteLine($"Mais saudável? {!comprouSorvete}");
        }
    }
}
