using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    sealed class SemFilho { // métodos selados não é possível sobrescrever
        public double Dinheiro() {
            return 1_407_033.65;
        }
    }

    //class SouFilho : SemFilho { não é possível sobrescrever sealed

    //}

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public sealed override bool HonrarNomeFamilia() {
            return true;
        }
    }

    class FilhoRebelde : Pai {
        //public override bool HonrarNomeFamilia() { não é possível sobrescrever sealed
        //    return false;
        //}
    }

    class Sealed {
        public static void Executar() {
            SemFilho semfilho = new SemFilho();
            Console.WriteLine(semfilho.Dinheiro());

            FilhoRebelde filhoRebelde = new FilhoRebelde();
            Console.WriteLine(filhoRebelde.HonrarNomeFamilia());
        }
    }
}
