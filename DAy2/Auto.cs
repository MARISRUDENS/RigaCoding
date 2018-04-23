using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Auto
    {
        //Konstruktors. uz to norāda:
        //1) nav rezultāta tipa
        //2) nosaukums sakrīt ar klases nosaukumu -vienmēr
        public Auto()
        {
            this.Marka = "Nezināms";
            this.Krasa = "Nezināms";
          
        }
        //auto marka
        public string Marka;

        //auto krāsa
        public string Krasa;

        public void Info()

        {
            //this pasaka, ka mainīgais nav jāmeklē funkcijā, bet klasē. 
            //this nav obligāts, var arī nelietot


            //ja šādi rakstīs, tad krāsa tiks izvadīta zila
            //string Krasa = "zila";
            Console.WriteLine("auto marka ir " + this.Marka);
            Console.WriteLine("auto krāsa ir " + Krasa);
                
        }
    }
}
