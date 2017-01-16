using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programik
{
    interface IZarzadzaj
    {
        void DodajAutobus(int iloscMiejsc);
        void Samolot(int iloscMiejsc, int odleglosc);
        void UsunOstatni();
        void Wyczysc();
    }
}
