using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programik
{
    abstract class SrodekLokomocji
    {
        protected int iloscMiejsc;
        protected double cenaBiletu;
        public SrodekLokomocji() { } // konstruktor domyslny
        public virtual void ObliczCene() // metoda wirtualna
        {
            cenaBiletu = Convert.ToInt32(iloscMiejsc * 3);
        }
        public double PobierzCene() // metoda zwracajaca cene biletu
        {
            return cenaBiletu;
        }
    }
}
