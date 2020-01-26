using System;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {
        public static void Executar() {
            // Preço Desconto
            var preco = 1000;
            var imposto = 355;
            var desconto = 0.9;

            double total = preco + imposto;
            var totalDesconto = total * desconto;
            Console.WriteLine($"O preço com desconto é de {totalDesconto}");

            // IMC
            double peso = 56.2;
            double altura = 1.78;
            // C# não tem operador para potencianção
            // Portanto é usado Math.Pow(base, expoente)
            double imc = peso / Math.Pow(altura, 2); 
            Console.WriteLine("Seu índice de massa corporal é {0}", imc);


            // Número Par e Ímpar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
