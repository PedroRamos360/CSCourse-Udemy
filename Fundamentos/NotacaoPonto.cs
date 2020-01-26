using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            string saudacao = "olá".ToUpper().Insert(3, " World!").Replace("World!", "Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("Teste".Length);

            //string valorImportante = null;
            //Console.WriteLine(valorImportante.Length);
            // gera erro
            // não é possível contar o tamanho de uma váriavel indefinida

            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
            // o ponto de interrogação faz com que ele conte o tamanho da váriavel apenas
            // se esta estiver definida
        }
    }
}
