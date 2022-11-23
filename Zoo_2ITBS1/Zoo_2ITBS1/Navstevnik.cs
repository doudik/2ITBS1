using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_2ITBS1
{
    internal class Navstevnik
    {
        string jmeno;
        float penize;
        public Navstevnik(string jmeno, float penize)
        {
            this.jmeno = jmeno;
            this.penize = penize;
        }
        void VstupDoZoo(Zoo zoo)
        {
            if (penize >= zoo.vstupne && zoo.kapacita > 0 && zoo.otevreno == true)
            {
                zoo.listNavstevniku.Add(this);
                penize -= zoo.vstupne;
                zoo.kapacita--;
            }
            else
            {
                //TODO vypis hlasku, ze nemuzes do zoo Alert.Box("HAHA")
            }
        }
        void OdejitZeZoo(Zoo zoo)
        {
            if (zoo.listNavstevniku.Contains(this))
            {
                zoo.kapacita++;
                zoo.listNavstevniku.Remove(this);
                //ALERTBOX pro odchod ze zoo
            }
        }
    }
}