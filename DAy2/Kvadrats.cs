using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Kvadrats
    {
        public int MalaGarums;
        public string Krasa;

        public Kvadrats()

        
        {

        }

        public Kvadrats(string krasa, int garums)
        {
            this.Krasa = krasa;
            this.MalaGarums = garums;
        }

        public void KrasasIzvade()
        {
            Console.WriteLine("Krāsa ir " + this.Krasa);
        }

        public int Laukums()
        {
            return   MalaGarums * MalaGarums;
        }
        public int Perimetrs()
        {
            return MalaGarums * 4;


        }
    }
}





    

