using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Auto
    {
        public string znacka {get;}
        public string model { get;}
        public float vykon { get; }
        public int pocetDveri { get; }

        public Auto(string znacka, string model, float vykon, int pocetDveri) {
            this.znacka = znacka;
            this.model = model;
            this.vykon = vykon;
            this.pocetDveri = pocetDveri;
        }
    }
}
