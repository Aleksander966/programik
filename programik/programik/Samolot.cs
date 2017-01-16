using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programik
{
    class Samolot : SrodekLokomocji
    {
        private int odleglosc;

        public override void ObliczCene()
        {
            if (odleglosc > 200)
            {
                cenaBiletu = odleglosc * 2.56 * iloscMiejsc;
            }
            else
            {
                cenaBiletu = 24 * iloscMiejsc;
            }
        }
        public Samolot(int iloscMiejsc,int odleglosc)
        {
            this.iloscMiejsc = iloscMiejsc;
            this.odleglosc = odleglosc;
            ObliczCene(); // metoda przeslonieta
        }
        public override string ToString()
        {
            return "Samolot:ilosc miejsc" + iloscMiejsc + ",odleglosc" + odleglosc + ",cena biletu" + cenaBiletu;
        }
    }
}
