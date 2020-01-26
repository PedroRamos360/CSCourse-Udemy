using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Params {
        // passar lista para uma função
        public static void Recepcionar(params string[] pessoas) { // [] representam array
            foreach(var pessoa in pessoas) {
                Console.WriteLine("Olá {0}", pessoa);
            }
        }
        public static void Executar() {
            Recepcionar("Pedro", "Eduarda", "Vinicius", "Geovani", "Bruno", "e Tchau");
        }
    }
}
