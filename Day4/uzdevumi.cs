using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Uzdevumi
    {
        public void Aprekini()
        {
            Console.WriteLine("attālums metros:" );
            int attalums = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("patērētais laiks h:");
            int laiksh = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("patērētais laiks m: ");
            int laiksm = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("patērētais laiks s: ");
            int laikss = Convert.ToInt32(Console.ReadLine());

            //1. kopējais laiks sekundēs
            int laiksSek = laiksh * 60 * 60 + laiksm * 60 + laikss;
            

            //2. ātrums m/s
            double speedMs = (double) attalums / laiksSek;
         


            //3. ātrums km/h
            double speedKmh = (((double)attalums / 1000) / (laiksSek / (60* 60)));
            

            //4. attālums kilometros
            double attalumsKm = (double)attalums / 1000;
            

            //5. attalums jūdzēs
            double attalumsJudz = (double)attalumsKm * 0.621371;
            

            Console.WriteLine("kopējais laiks s =  " + laiksSek);
            Console.WriteLine("Ātrums  m/s =  " + speedMs);
            Console.WriteLine("Attālums km =  " + attalumsKm);
            Console.WriteLine("ātrums km/h =  " + speedKmh);
            Console.WriteLine("attālums jūdzēs =  " + attalumsJudz);

            Console.ReadLine();
        }
    }
}
