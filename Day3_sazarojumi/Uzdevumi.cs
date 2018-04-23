using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_sazarojumi
{
    class Uzdevumi
    {
        public void MenesaDienas()
        {
           Console.Write("Ievadi mēneša nosaukumu: ");
           string menesis = Console.ReadLine();
            
        if (menesis == "feb")
            {
            Console.WriteLine("dienu skaits: 28");
            }
    else if (menesis == "apr")
        {
        Console.WriteLine("dienu skaits: 30");
        }
    else if (menesis == "jūn")    
        {
    Console.WriteLine("dienu skaits: 30");
    }
    else if (menesis == "sep")
    {
    Console.WriteLine("dienu skaits: 30");
    }
    else if (menesis == "nov")
    {
    Console.WriteLine("dienu skaits: 30");
    }
    else 
    {
    Console.WriteLine("dienu skaits: 31");
          //vienā rindā apvienot var:
          //else if(menesis == "Apr" || menesis == "Jūn" || ...) 
          // Console.WriteLine("dienu skaits: 30");
    }
    }

        public void VienadiSkaitli()
        {
            Console.Write("ievadi pirmo skaitli: ");
            int skaitlis1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("ievadi otro skaitli: ");
            int skaitlis2 = Convert.ToInt32(Console.ReadLine());
        

            if (skaitlis1 == skaitlis2)
            {
                Console.WriteLine("skaitļi ir vienādi");
                    }
            else
            {
                Console.WriteLine("skaitļi nav vienādi");
            }
        }
    }
}
