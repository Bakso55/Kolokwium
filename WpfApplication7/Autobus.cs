using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    class Autobus : SrodekLokomocji
    {
        public Autobus(int iloscMiejsc)

        {
            this.iloscMiejsc = iloscMiejsc;
            base.ObliczCene();
        }
        public override string ToString()
        {
            return "Autobus: ilosc miejsc: " + iloscMiejsc + ", cena biletu: " + Cena();
        }
    }
}
