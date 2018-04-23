using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_klases
{
    class Program
    {
        public static void Main(string[] args)

        {
            //1.mainīgā tips = ManaPirmaKlase
            //2.mainīga nosaukums = objekts
            //3.sākotnējā vērtība = jauns objekts

            ManaPirmaKlase objekts = new ManaPirmaKlase();
            objekts.SayHello();
            objekts.SayHello();
        
            int rezultats = objekts.GetNumber();
            int rezultats2 = objekts.GetNumber2(100);

            Console.WriteLine(rezultats);
            Console.WriteLine(rezultats2);


            Uzdevumi uzdevumi = new Uzdevumi();
            
            uzdevumi.Uzdevums1("Māris");
            
               

            uzdevumi.Uzdevums2(142, 23);
            Console.ReadLine();

        }
    }
}
