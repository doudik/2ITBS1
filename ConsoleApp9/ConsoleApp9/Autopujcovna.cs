using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Autopujcovna
    {
        string nazev;
        List<Auto> auta = new List<Auto>();
        List<Auto> mozneAuticka = new List<Auto>();
        Random random = new Random();

        public Autopujcovna(string nazev) {
            this.nazev = nazev;
            GeneratorAut();
            VyberAuticka(5);
        }

        void GeneratorAut() {
            mozneAuticka.Add(new Auto("Audi", "A8", 99f, 5));
            mozneAuticka.Add(new Auto("Audi", "A7", 192f, 5));
            mozneAuticka.Add(new Auto("Audi", "A3", 81f, 3));
            mozneAuticka.Add(new Auto("Audi", "A1", 81f, 3));
            mozneAuticka.Add(new Auto("Audi", "A2", 81f, 3));
            mozneAuticka.Add(new Auto("Audi", "A9", 81f, 3));
            mozneAuticka.Add(new Auto("Audi", "A11", 81f, 3));
            mozneAuticka.Add(new Auto("Audi", "A12", 81f, 3));
            mozneAuticka.Add(new Auto("Audi", "A13", 81f, 3));
            mozneAuticka.Add(new Auto("Audi", "A14", 81f, 3));
        }
        void VyberAuticka(int pocet) {
            if (pocet <= mozneAuticka.Count)
            {
                for (int i = 0; i < pocet; i++)
                {
                    int index = random.Next(0, mozneAuticka.Count);
                    auta.Add(mozneAuticka[index]);
                    mozneAuticka.RemoveAt(index);
                }
            }
            else {
                Console.WriteLine("Nemáme dostatek jiných aut!");
            }
            
        }
        public void VypisAuticka() {
            foreach (var item in auta) {
                Console.WriteLine("Značka: {0}, Model: {1}, Výkon: {2}kw, Počet dveří: {3}",
                    item.znacka, item.model, item.vykon, item.pocetDveri);
            }
        }
    }
}
