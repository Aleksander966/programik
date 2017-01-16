using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programik
{
    class Autobus : SrodekLokomocji
    {
        public Autobus(int iloscMiejsc) // konstruktor parametryczny 
        {
            this.iloscMiejsc = iloscMiejsc;
            ObliczCene();
        }
        public override string ToString() //przeslanianie metody ToString()
        {
            return "Autobus:ilosc miejsc" + iloscMiejsc + ",cena biletu" + cenaBiletu;
        }
    }
}
