using System;
using System.Collections.Generic;
using System.Text;

namespace Szkolenie_Klasy_kolejne
{
    internal class MojaKlasa
    {
        public int Dana { get; set; }

        public MojaKlasa(int d)
        {
            Dana = d;
        }
        public MojaKlasa(MojaKlasa kopia)
        {
            Dana = kopia.Dana;
        }
    }
}
