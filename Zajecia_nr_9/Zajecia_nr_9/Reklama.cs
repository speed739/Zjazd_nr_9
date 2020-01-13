using System;
using System.Collections.Generic;
using System.Text;

namespace Zajecia_nr_9
{
    class Reklama
    {
        public string Tekst { get; set; }
        public GrupaWiekowa grupawiekowa;
        public Zainteresowania zainteresowania;

        public Reklama(string tekst, GrupaWiekowa grupa, Zainteresowania zainteresowania)
        {
            this.grupawiekowa = grupa;
            tekst = Tekst;
            this.zainteresowania = zainteresowania;
        }

    }
}
