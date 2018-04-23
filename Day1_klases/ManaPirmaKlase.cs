using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_klases
{
    public class ManaPirmaKlase
    {
        /// <summary>
        /// funkcija bez rezultāta
        /// un bez ievadparametriem
        /// </summary>     
        public void SayHello()

        {
            Console.WriteLine("neko nesaprotu");
        }
        /// <summary>
        /// funkcija ar rezultātu 
        /// un bez ievadparamteriem

        /// </summary>
        /// <returns>Skaitlis</returns>
        public int GetNumber()
        {
            //int atgriež skaitli
            return 99;
        }/// <summary>
         /// funkcija ar rezultātu 
         /// ar ievadparametru
         /// </summary>
         /// <param name="skaitlis"></param>
         /// <returns>to pašu skaitli</returns>
        public int GetNumber2(int skaitlis)
        {
            return skaitlis;
        }
    }
}
