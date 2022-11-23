using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_2ITBS1
{
    internal class Chovatel
    {


        //[Opečovávatel]
        //jmeno, pohlavi, vek
        public string jmeno { get; }
        bool pohlavi; //false - žena | true - MUŽ<33
        int vek;
        Random rnd = new Random();
        string[] jmenaChovatelu = { "Miroslav", "Verča", "Ondra", "Pepča", "Karel", "Josefínka", "Vratislav" };
        public List<Vybeh> listVybehuOkteresestara = new List<Vybeh>();
        public Chovatel()
        {
            jmeno = jmenaChovatelu[rnd.Next(0, jmenaChovatelu.Length - 1)]; 
            pohlavi = rnd.Next(0,2) == 1 ? true : false;
            vek = rnd.Next(25, 100);
        }

        public void NakrmZviratko(Zviratko zviratko)
        {
            //jdi do skladu a vem potravinu, kterou zvířátko jí
            int index = Sklad.potravinySklad.IndexOf(ZkontrolujPotravinyVeSkladu(zviratko));
            int index2 = zviratko.coPapam.IndexOf(ZkontrolujPotravinyVeSkladu(zviratko));
            //odeber potravinu ze skladu a dej ji zviratku
            Sklad.potravinySklad[index].mnozstvi = Sklad.potravinySklad[index].mnozstvi - zviratko.coPapam[index2].mnozstvi;
            //zviratko je happy a nemá hlad :( neumím psát <33 UWU čupapi To jsem já 
            zviratko.maHlad = false;

        }
        Potraviny ZkontrolujPotravinyVeSkladu(Zviratko zviratko)
        {
            for (int i = 0; i < zviratko.coPapam.Count; i++)
            {
                if (Sklad.potravinySklad.Contains(zviratko.coPapam[i]) &&
                    Sklad.potravinySklad[i].mnozstvi >= zviratko.coPapam[i].mnozstvi)
                {
                    return Sklad.potravinySklad[i];
                }
                else
                {
                    // TODO LABEL
                }
            }
            return null;
        }


    }
}