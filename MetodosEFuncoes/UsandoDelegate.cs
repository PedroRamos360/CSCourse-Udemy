using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class UsandoDelegate {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y) {
            return x + y;
        }
        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a + b);
        }
        public static void Executar() {
            Soma op1 = MinhaSoma;
            ImprimirSoma op2 = MeuImprimirSoma;

            Console.WriteLine(op1(781883, 781883));
            op2(781883, 781883);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(781883, 781883));

            Action<double, double> op4 = MeuImprimirSoma;
            op4(781883, 781883);
        }
    }
}
