using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo_2ITBS1
{
    internal class Vybeh
    {
        public List<Zviratko> listZviratekVeVybehu;
        public string pojmenovani { get; }

        public Vybeh(string pojmenovani)
        {
            this.pojmenovani = pojmenovani;
        }
    }
}