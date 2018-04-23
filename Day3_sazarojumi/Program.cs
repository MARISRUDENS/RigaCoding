using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_sazarojumi
{
    class Program
    {
        static void Main(string[] args)
        {
            Uzdevumi uzd = new Uzdevumi();
            //uzd.VienadiSkaitli();
            uzd.MenesaDienas();
            Console.ReadLine();

        }

        public void Piemers()
        { 
        int skaitlis = 5;

        //pārbaudes rezultāts - vai skaitlis ir vienāds ar 5
        bool vaiirvienadsarpieci = skaitlis == 5;

            //ja skaitlis ir lielāks nekā 5
            if (skaitlis > 5)
            {
          
                Console.WriteLine("skaitlis ir lielāks par 5");
            }
            //ja skaitlis ir vienāds ar 5
            else if (vaiirvienadsarpieci)
            {
                Console.WriteLine("skaitlis ir vienāds ar 5");
            }
            //citādi
            else
            {
                Console.WriteLine("skaitlis nav lielāks par 5");
            }
            Console.ReadLine();
        }
            



    }
}
