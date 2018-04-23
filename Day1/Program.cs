using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    public class Program
        //funkcijas definē klasē
    {
        public static void Main(string[] args)
            //public static void nozīmē, ka būs funkcija bez objekta piesaistes
        {
            //teksta ievade konsolē ""
            Console.WriteLine("Hello World!");
            //cipari ievadās bez pēdiņām
            Console.WriteLine(9);
            //decimaļus atdala ar .
            Console.WriteLine(4.6);
            //simbola izvade ar vienām pēdiņām, var ierakstīt tikai vienu simbolu ''
            Console.WriteLine('T');

            int skaitlis1 = 9223;
            //int -tips
            Console.WriteLine(skaitlis1);
            //Console.WriteLine("skaitlis1");
            OutPutNumber();
            SayHello();
            //jāievēro definēšanas secība - būs kļūda, ja to neizdarīs. Programma uztver visu tikai no augšas uz leju
            /*
             nepareizi: 
             Console.WriteLine(skaitlis3);
             int skaitlis3=4
           */
            Console.ReadLine();
            
        }
        public static void SayHello()
        //void nozīmē funkcija bez rezultāta
    {
        Console.WriteLine("Hello");
          
    }
    public static void OutPutNumber()
      {
      Console.WriteLine(9);
    }
    
    } 
}
