using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    class Samolot : SrodekLokomocji
    {
        private int odleglosc;
        public override void ObliczCene()
        {
            if (odleglosc > 200)
            {
                cenaBiletu = odleglosc * 2.56;
            }
            else base.ObliczCene();
        }
        public Samolot(int iloscMiejsc, int odleglosc)
        {
            this.iloscMiejsc = iloscMiejsc;
            this.odleglosc = odleglosc;
            this.ObliczCene();
        }
        public override string ToString()
        {
            return "Samolot: ilosc miejsc: " + iloscMiejsc + ", odleglosc:  " + odleglosc + ", cena biletu: " + Cena();
        }
    }
}
