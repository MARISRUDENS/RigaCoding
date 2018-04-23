using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {

    // GAlvenais ieejas punkts programmā
   
       static void Main(string[] args)

        {
            
            // izveido jaunu obkjektu no klases Uzdevumi

            /* Uzdevumi uzd = new Uzdevumi();
             uzd.Starpiba(132, 52);*/

            /* Uzdevumi reiz = new Uzdevumi();
             reiz.Reizinajums(132, 52);*/

            /* Uzdevumi reiz2 = new Uzdevumi();
             reiz2.Reizinajums(132, 52, 45);*/

            /*Uzdevumi apmaina = new Uzdevumi();
            apmaina.skaitlumaina(5, 6);*/



            // Uzdevumi garais = new Uzdevumi();
            //garais.aprekini(5, 2);


            ///izsauc objekta funkcijas
            //garais.Temperatura();


            //funkcijas, kas patur atvērtu logu
            //līdz mēs nospiežam enter



            /*
            Auto auto = new Auto();
            auto.Krasa = "Melns";
            auto.Marka = "BMW";
            auto.Info();
            


            Auto vw = new Auto();
            vw.Krasa = "Zaļš";
            vw.Marka = "VW";
            vw.Info();


            Auto nezinams = new Auto();
            nezinams.Info();
            */

            Kvadrats kv1 = new Kvadrats();
            kv1.Krasa = "sarkans";
            kv1.MalaGarums = 10;
            kv1.KrasasIzvade();
            int laukums = kv1.Laukums();
            Console.WriteLine("Laukums ir " + laukums);
            Console.WriteLine("Perimetrs ir " + kv1.Perimetrs());

            Kvadrats kv2 = new Kvadrats("melns", 10);
            kv2.KrasasIzvade();

            Console.WriteLine("Perimetrs ir " + kv2.Perimetrs());

            Console.ReadLine();



        }
    }
}
