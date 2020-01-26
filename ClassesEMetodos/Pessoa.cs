using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {
        // conveção: usar pascal case => EsteÉUmExemploDePascalCase
        
        // Atributos
        public string Nome;
        public int Idade;

        // Métodos
        public string Apresentar() {
            return string.Format("Olá! me chamo {0} e tenho {1} anos", Nome, Idade);
        }

        // void signifca vazio ou seja não recebe não não retorna nada
        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar()); // não usar
        }

        public void Zerar() {
            Nome = "";
            Idade = 0;
        }
    }
}
