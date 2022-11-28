using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeRacer
{
    internal class TypeRacer
    {

        static List<string> vety = new List<string>();
        //TypeRacer
        //1. Načíst soubor
        //  a. Načíst soubor
        //  b. Uložit soubor do stringu 
        //2. Rozdělit string na věty
        //  a. načíst větu
        public static void Start(Form1 form) {
            NactiVety();
            VypisVetu(form);
        }
        private static string NactiText(){          
            return System.IO.File.ReadAllText("./text.txt");
        }
        static void NactiVety() {
            string[] pocetVet = NactiText().Split(".");
            for (int i = 0; i < pocetVet.Length - 1; i++)
            {
                vety.Add(pocetVet[i]);
            }
        }
        static string VyberVetu() {
            Random rnd = new Random();
            string v = vety[rnd.Next(0, vety.Count)];
            vety.Remove(v);
            return v;
        }
        //3. Rozdělit string na char //Šimon A KOLEGA PETR DUNAJ
        char[] RozdelVetuNaChar(string veta) {
            return veta.ToCharArray();
        }
        
        //4. Výpis uživateli
        static void VypisVetu(Form1 form) {
            //  a. Vypsat uživateli char větu
            form.label_text.Text = VyberVetu();
        }
        //5.Kontroluj jestli píše správně)))

    }

    
}