using System;
using System.Collections;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesArrayList {
        public static void Executar() {
            var arraylist = new ArrayList { // Evitar ArrayList com valores heterogêneos
                "Palavra", // string
                3, // int
                true, // boolean
            };

            arraylist.Add(3.14); // double
            foreach (var item in arraylist) {
                Console.WriteLine("{0} ==> {1}", item, item.GetType());
            }
        }
    }
}
