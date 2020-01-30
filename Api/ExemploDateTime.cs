using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Api {
    class ExemploDateTime {
        public static void Executar() {
            var dateTime = new DateTime(year: 2004, month: 5, day: 4);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);

            // Data sem hora
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // Data com hora
            var dataAtual = DateTime.Now;
            Console.WriteLine(dataAtual);
            Console.WriteLine("Hora: " + dataAtual.Hour);
            Console.WriteLine("Minutos " + dataAtual.Minute);

            var amanha = dataAtual.AddDays(1);
            Console.WriteLine(amanha);

            var ontem = dataAtual.AddDays(-1);
            Console.WriteLine(ontem);

            Console.WriteLine(dataAtual.ToString("dd"));
            Console.WriteLine(dataAtual.ToString("d"));
            Console.WriteLine(dataAtual.ToString("D"));
            Console.WriteLine(dataAtual.ToString("g"));
            Console.WriteLine(dataAtual.ToString("G"));
            Console.WriteLine(dataAtual.ToString("dd-MM-yy HH:mm"));
        }
    }
}
