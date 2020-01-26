using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    public abstract class Celular {
        public abstract string Assistente();

        public string Tocar() {
            return "Trim trim trim...";
        }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá meu nome é Bixby!";
        }
    }

    public class Xiaomi : Celular {
        public override string Assistente() {
            return "Olá meu nome é Google Assistente!";
        }
    }

    public class IPhone : Celular {
        public override string Assistente() {
            return "Olá meu nome é Siri!";
        }
    }

    class Abstract { // classes não instanciáveis feita para ser herdada
        public static void Executar() {
            var celulares = new List<Celular> {
                new IPhone(),
                new Samsung(),
                new Xiaomi(),
            };

            foreach (var celular in celulares) {
                Console.WriteLine(celular.Assistente());
            }
        }
    }
}
