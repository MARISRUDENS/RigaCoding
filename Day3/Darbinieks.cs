using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Darbinieks
    {


        public string Vards;
        public string Uzvards;
        public int DzGads;
        public string Epasts;
        public string Talrunis;
        public Adrese Dzivesvieta;
        public Nodala AktualaNodala;
        public Nodala IeprieksejaNodala;


        public void Teikums1()
        {
            Console.WriteLine("Mani sauc " + Vards + " es dzīvoju " + Dzivesvieta.PilnaAdrese());
        }
        public void TeikumsDivi()
        {
            Console.WriteLine("Mani sauc " + Vards
                                + " un es pārgāju uz  "
                                + AktualaNodala.Nosaukums
                                + " no " + IeprieksejaNodala.Nosaukums
                                + " kura atradās "
                                + IeprieksejaNodala.AtrasanasVieta.PilnaAdrese());
        }

    }
}