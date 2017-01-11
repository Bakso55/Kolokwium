using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    abstract class SrodekLokomocji
    {
        protected int iloscMiejsc;
        protected double cenaBiletu;
        public SrodekLokomocji() { }
        public virtual void ObliczCene()
        {
            cenaBiletu = 24;
        }
        public double Cena()
        {
            return cenaBiletu;
        }
    }
}
