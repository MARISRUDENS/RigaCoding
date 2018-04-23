using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_cikli
{
    class Uzdevumi
    {
        public void Gadi()
        {
            //1.paprasa ievadīt gadskaiti
            //2.nolasa ievadito skaitli
            //3.izvada visus gadaskaitļun no ievadītā līdz 2018

            Console.WriteLine("Ievadi gadskaitli: ");
            int GadsNo = Convert.ToInt32(Console.ReadLine());
            //for (int gads = GadsNo; gads <= 2018; gads++)
            //gada vietā var rakstīt DateTime.Now.Year
            for (int gads = GadsNo; gads <= DateTime.Now.Year; gads++)

            {
                Console.WriteLine(gads + ". gads");
            }

        }

        public void SkaitliN()

        {


            //paprasas ievadīt skaitu N
            Console.WriteLine("ievadi atkārtojumu skaitu: ");
            //nolasa ievadīto vērtību

            int n = Convert.ToInt32(Console.ReadLine());
            //cikliski prasa ievadīt N vērtibas
            int summa = 0;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("ievadi " + i + ". skaitli: ");
                //aprēķina ievadīto sakitļu kopsummu
                int skaitlis = Convert.ToInt32(Console.ReadLine());
                summa = summa + skaitlis;
                //vai arī:  summa+=skaitlis;
            }
                Console.WriteLine("summa ir " + summa);
                //aprēķina ievadīto skaitļu vidējo vēŗtību
                Console.WriteLine("Vidējā vērtība ir " + (summa / n));
            




            }
        public void Rezgis()

        {
            Console.WriteLine("skaits N: ");

            int n = Convert.ToInt32(Console.ReadLine());

            for (int rinda = 1; rinda <= n; rinda++)
            {
                Console.WriteLine();
                for (int kolona = 1; kolona <= n; kolona++)
                {
Console.Write("#");
                }
            }
            {
                
            }

        }
        }
    }



    

