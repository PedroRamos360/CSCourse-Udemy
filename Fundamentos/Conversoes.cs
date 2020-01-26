using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine($"Nota sem perca de dados: {quebrado}");
            // Nessa conversão não há perca de dados
            // já que o double aceita valores inteiros também

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine($"Nota Truncada: {notaTruncada}");
            // (int) para converter double para int
            // Não há arredondamentos apenas perca de dados
            // resultado 9

            Console.Write("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeInt = int.Parse(idadeString);
            Console.WriteLine($"Idade convertida para inteiro: {idadeInt}");
            // int.Parse para converter para string para int

            idadeInt = Convert.ToInt32(idadeString);
            Console.WriteLine($"Resultado da conversão: {idadeInt}");
            // outro método de conversão string para int

            Console.Write("Digite o primeiro número: ");
            string palavras = Console.ReadLine();
            int numero1;
            int.TryParse(palavras, out numero1);
            Console.WriteLine($"Resultado1: {numero1}");
            // Tenta fazer a conversão de string para int
            // se não for possível retorna 0

            Console.Write("Digite o segundo número: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine($"Resultado2: {numero2}");
            // declara a váriavel na mesma linha com o out int
            // deixa o código mais otimizado
        }
    }
}
