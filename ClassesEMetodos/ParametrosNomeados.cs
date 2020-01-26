using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosNomeados {
        public static void Formatar(int dia, int mes, int ano, bool FormatacaoEUA) {
            if (FormatacaoEUA) {
                Console.WriteLine("{0:D2}/{1:D2}/{2:D2}", mes, dia, ano);
            } else {
                Console.WriteLine("{0:D2}/{1:D2}/{2:D2}", dia, mes, ano);
            }
        }
        public static void Executar() {
            // Parâmetros Nomeados deixam o código mais legível
            Formatar(mes: 5, dia: 4, ano: 2004, FormatacaoEUA: false);
        }
    }
}
