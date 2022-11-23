using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo_2ITBS1;

namespace Zoo_2ITBS1
{
    internal class Zviratko
    {
        //[Zvířátko]
        //jmeno, druhZvirete, pohlavi
        //List<Potravina> coPapa
        //rodič

        //opečovávatel?
        public string jmeno { get; private set; }
        private string druhZvirete;
        private bool pohlavi; //false - žena | true - SIGMA(MUŽ)
        public bool maHlad { get; set; }
        bool bylozravec;



        public static string[] jmenaZviratek = { "Josef", "Gertrůda", "Ondra", "Ingrid", "Miroslav", "Honza", "Patrik", "Dan", "Vojta", 
            "Marek", "Sebastian","Eda", "Ondřej Krucký" };
        public static string[] druhyZvirete = { "Křeček", "Had", "Pes", "Kočka", "Orangutan", "Slon", "Nosorožec", "Žralok", "Krokodýl", "Surikata", "Mlok", "Čolek", 
            "Opice", "Žížala", "Krteček", "Pavián", "Lemur", "Makak", "Ptakopysk", "Kapybara", "Jakub Mičán", "Pavián", "Pásovec", 
            "Malý růžový pásovec", "Jelen", "Elaphodus Cephalophus", "Srnec", "Amogus", "Divochus" };

        public List<Potraviny> coPapam = new List<Potraviny>();
        public Zviratko(string jmeno, string druhZvirete, bool pohlavi, bool bylozravec, List<Potraviny> coPapam)
        {
            this.jmeno = jmeno;
            this.druhZvirete = druhZvirete;
            this.pohlavi = pohlavi;
            this.bylozravec = bylozravec;
            maHlad = false;
            this.coPapam = coPapam;
        }
        
    }
}