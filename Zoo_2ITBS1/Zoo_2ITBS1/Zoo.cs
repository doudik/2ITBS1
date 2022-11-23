using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_2ITBS1;

namespace Zoo_2ITBS1
{
    internal class Zoo
    {
        //List<Návštěvník>
        //jmeno, velikost, vstupne, kapacita, otevreno
        string jmeno;
        float velikost;
        public float vstupne { get; }
        public int kapacita { get; set; }
        public bool otevreno { get; }
        public List<Navstevnik> listNavstevniku = new List<Navstevnik>();
        public List<Zviratko> dostupnaZviratkaVZoo = new List<Zviratko>();
        public List<Chovatel> dostupniChovatele = new List<Chovatel>();
        public List<Vybeh> dostupneVybehy = new List<Vybeh>();
        Random rnd = new Random();
        public Zoo(string jmeno, float velikost, float vstupne, int kapacita, bool otevreno)
        {
            this.jmeno = jmeno;
            this.velikost = velikost;
            this.vstupne = vstupne;
            this.kapacita = kapacita;
            this.otevreno = otevreno;
            GenerujZviratka(200);
            PriradZviratkoDoVybehu(dostupnaZviratkaVZoo[rnd.Next(0, dostupnaZviratkaVZoo.Count)], dostupneVybehy[rnd.Next(0, dostupneVybehy.Count)]);
            GenerujChovatele(5);
            //TODO dopsat vybehy
        }
        void GenerujZviratka(int pocet)
        {
            Random rnd = new Random();
            for (int i = 0; i < pocet; i++)
            {
                bool volba = rnd.Next(0, 2) == 1 ? true : false;
                Zviratko z = new Zviratko(Zviratko.jmenaZviratek[rnd.Next(0, Zviratko.jmenaZviratek.Length)],
                    Zviratko.druhyZvirete[rnd.Next(0, Zviratko.druhyZvirete.Length)],
                    rnd.Next(0, 2) == 1 ? true : false,
                    volba,
                    volba == false ? Potraviny.potravaProBylozravce : Potraviny.potravaProMasozravce);
                dostupnaZviratkaVZoo.Add(z);
            }    
            
            //TODO dodě(L)at možnost, pokud není nějaký výběh obstaráván
        }
        void GenerujChovatele(int pocet)
        {
            Random rnd = new Random();
            for (int i = 0; i < pocet; i++)
            {
                Chovatel z = new Chovatel();
                dostupniChovatele.Add(z);
                z.listVybehuOkteresestara.Add(dostupneVybehy[rnd.Next(0, dostupneVybehy.Count)]);
            }
        }
        void PriradZviratkoDoVybehu(Zviratko zviratko, Vybeh vybeh)
        {
            foreach (Vybeh item in dostupneVybehy)
            {
                if (item.pojmenovani == vybeh.pojmenovani)
                {
                    if (item.listZviratekVeVybehu.Count <= 5)
                    {
                        item.listZviratekVeVybehu.Add(zviratko);
                    }
                }
                else
                {
                    //je to plné či to neexistuje :)
                    dostupneVybehy.Add(new Vybeh(zviratko.jmeno));
                }
            }
        }

    }
}//Ahoj Paťo!!