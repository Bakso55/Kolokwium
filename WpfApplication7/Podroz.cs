using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication7
{
    class Podroz : IZarzadzaj, IData
    {
        private DateTime dataPodrozy;
        private List<SrodekLokomocji> planPodrozy = new List<SrodekLokomocji>();
        private double koszt = 200;
        public void DodajAutobus(int iloscMiejsc)
        {
            planPodrozy.Add(new Autobus(iloscMiejsc));

        }
        public void DodajSamolot(int iloscMiejsc, int odleglosc)
        {
            planPodrozy.Add(new Samolot(iloscMiejsc, odleglosc));
            
        }
        public void UsunOstatni()
        {
            planPodrozy.Remove(planPodrozy.Last());

        }
        public void Wyczysc()
        {
            planPodrozy.Clear();
        }
        public void UstawDate(DateTime data)
        {
            dataPodrozy = data;

        }
        public bool SprawdzDate()
        {
            return dataPodrozy > DateTime.Now;
        }
        public override string ToString()
        {
            string output = string.Empty;
            foreach (var p in planPodrozy)
                output += p.ToString() + '\n';
            return output;
        }

    }
}
