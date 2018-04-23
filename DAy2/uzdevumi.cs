using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Uzdevumi
    {
        public void Starpiba(int skaitlis1, int skaitlis2)
        {
            int starpiba = skaitlis1 - skaitlis2;
            Console.WriteLine(starpiba);

        }
        public void Reizinajums(int skaitlis1, int skaitlis2)
        {
            int reizinajums = skaitlis1 * skaitlis2;
            Console.WriteLine(reizinajums);

        }
        public void Reizinajums(int skaitlis1, int skaitlis2, int skaitlis3)
        {
            long reizinajums = skaitlis1 * skaitlis2 * skaitlis3;
            Console.WriteLine(reizinajums);


        }
        public void skaitlumaina(int skaitlis1, int skaitlis2)
        {
            Console.WriteLine("skaitlis1 = " + skaitlis1);
            Console.WriteLine("skaitlis2 = " + skaitlis2);


            int skaitlis1Vacavertiba = skaitlis1;
            skaitlis1 = skaitlis2;
            skaitlis2 = skaitlis1Vacavertiba;

            Console.WriteLine("skaitlis1 = " + skaitlis1);
            Console.WriteLine("skaitlis2 = " + skaitlis2);

        }
        public void aprekini(int skaitlis1, int skaitlis2)
        {
            int summa = skaitlis1 + skaitlis2;
           Console.WriteLine(summa);

            int starpiba = skaitlis1 - skaitlis2;
           Console.WriteLine(starpiba);

            int rezinajums = skaitlis1 * skaitlis2;
           Console.WriteLine(rezinajums);

            double dalijums = (double) skaitlis1 / skaitlis2;
           Console.WriteLine(dalijums);

            int dalatlikums = skaitlis1 % skaitlis2;
            Console.WriteLine(dalatlikums);
            
        }
        /* WriteLine
        /// Write
        readLine
        ///read = 
        ///
        //Convert.ToInt32(text);*/
        
            
            //definejam funkciju īevadiVardu
        //kas nesaņem parametrus
        //un kas neatgriež vērtibu
        /*public void IevadiVardu()
        {
        
            //izvada tekstu un kursors paliek nākošā rindā
            Console.WriteLine("Ievadi Vārdu: ");
            string vards = Console.ReadLine();

            Console.WriteLine("Tavs vārds ir "+ vards);
            //ievada tekstu un kursors paliek tajā pašā rindā
            Console.Write("Ievadi skaitli: ");
            string skaitlisTekstuals = Console.ReadLine();
            

            //pārveido ievadīto tekstu uz skaitli
            int skaitlis = Convert.ToInt32(skaitlisTekstuals);

            //izvada rezultātu
            Console.WriteLine("Skaitlis ir " + skaitlis);*/

        public void Temperatura()
        {
            Console.Write("grādi pēc Celsija: ");
            string skaitlis = Console.ReadLine();

            int gradi = Convert.ToInt32(skaitlis);


            int skaitlisKelvin = gradi + 273;
            double skaitlisFaren = gradi * 9 / 5 + 32;

            Console.WriteLine("grādi pēc Kelvina: " + skaitlisKelvin);
            Console.WriteLine("grādi pēc Kelvina: " + skaitlisFaren);

            



        }
        
    }
}
