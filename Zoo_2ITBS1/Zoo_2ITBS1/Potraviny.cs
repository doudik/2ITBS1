using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_2ITBS1
{
    internal class Potraviny
    {
        static Random rnd = new Random();
        public static List<Potraviny> potravaProBylozravce = new List<Potraviny>() {
            new Potraviny("Tráva", rnd.Next(1000,5000)),
            new Potraviny("Seno", rnd.Next(1000,5000)),
            new Potraviny("Kopřiva", rnd.Next(1000,5000)),
            new Potraviny("Konopí", rnd.Next(1000,5000)),
            new Potraviny("bylinky", rnd.Next(1000,5000))
                   };
        public static List<Potraviny> potravaProMasozravce = new List<Potraviny>() {
            new Potraviny("Chamber maso", rnd.Next(1000,5000)),
            new Potraviny("Kuřecí maso", rnd.Next(1000,5000)),
            new Potraviny("Carska", rnd.Next(1000,5000)),
            new Potraviny("Jelení noha",rnd.Next(1000,5000)),
            new Potraviny("Kuřecí maso", rnd.Next(1000,5000)),
            new Potraviny("Omen", rnd.Next(1000,5000)),
            new Potraviny("Jett", rnd.Next(1000,5000)),
            new Potraviny("Koní zadní levá noha", rnd.Next(1000,5000)),
            new Potraviny("Brimstone(Taťka)", rnd.Next(1000,5000)),
            new Potraviny("Svíčková se šesti", rnd.Next(1000,5000))

        };
        public string nazev { get; }
        public float mnozstvi { get; set; }
        public Potraviny(string nazev, float mnozstvi)
        {
            this.nazev = nazev;
            this.mnozstvi = mnozstvi;
            Sklad.potravinySklad.Add(this);
        }
    }
}
