using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_hwork
{
    class Uzdevumi
    {
        public void Pilgadiba()
        {
            Console.Write("ievadi savu vecumu: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            if (skaitlis == 18)
            {
                Console.WriteLine("Tu esi pilngadīgs");
            }
            else if (skaitlis > 18)
            {
                Console.WriteLine("Tu esi pilngadīgs");
            }
            else if (skaitlis < 18)
            {
                Console.WriteLine("tu esi sīkais");
            }
        }

        public void Vidvertiba()

        {
            Console.Write("ievadi pirmo skaitli: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ievadi pirmo skaitli: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ievadi pirmo skaitli: ");
            int skaitlis3 = Convert.ToInt32(Console.ReadLine());

            Double Vidvertiba = (skaitlis1 + skaitlis2 + skaitlis3) / 3;
            Console.WriteLine(Vidvertiba);
        }


        public void SkParbaude()

        {
            //1.variants
            Console.WriteLine("Ievadi skaitli no -50 līdz 50: ");
            int sk = Convert.ToInt32(Console.ReadLine());

            if (sk > -50 || sk < 50)
            {
                Console.WriteLine("bingo");
            }

            if (sk >= -50)
            {
                if (sk <= 50)
                {
                    Console.WriteLine("skaitlis nav atbistošajā intervālā");
                }

                else
                {
                    Console.Write("skaitlis nav atbistošajā intervālā");
                }

            }
            //2.variants
            if (sk >= -50)
            {
                if (sk <= 50)
                {
                    Console.Write("skaitlis ir atbistošajā intervālā");
                    //return pārtrauc funkcijas tālāko izpildi
                    return;
                }
                Console.Write("skaitlis ir atbistošajā intervālā");

            }
            //3.variants
            if (sk >= -50 && sk <= 50)
            {
                Console.WriteLine("bingo");
            }
            else
            {
                Console.Write("skaitlis nav atbistošajā intervālā");
            }
        }






        public void GradiUzPretejo()

        {
            Console.WriteLine("ievadiet grādus: ");
            int gradi = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("ievadiet mērvienību (F/C): ");
            string mervieniba = Console.ReadLine();
            //pārvēršam uz Lielajiem burtiem
            mervieniba = mervieniba.ToUpper();

            double rezultats;

            //ja lietotājs ievada grādus pēc Fārenheita
            if (mervieniba == "F" || mervieniba == "f")

            {
                rezultats = ((double)gradi - 32) * 5 / 9;

                Console.WriteLine(rezultats + "C");

            }

            else if (mervieniba == "C")
            {
                rezultats = (double)gradi * 9 / 5 + 32;
                Console.WriteLine(rezultats + "F");

            }
            //visos citos gadījumos....

            else
            {
                Console.WriteLine("nezināma mērvienība!");
            }
            {

            }

        }





        public void VaiIrPara()
        {
            Console.Write("Ievadi sakitli: ");
            int skaitlis = Convert.ToInt32(Console.ReadLine());

            if (skaitlis % 2 == 0)
            {
                Console.Write("Ir pāra skaitlis");
            }
            else
            {
                Console.Write("Nav pāra skaitlis");
            }
        }
    }
}


    


