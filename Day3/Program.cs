using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        /*{
            Taisnsturis t1 = new Taisnsturis(3 , 54);
            Taisnsturis t2 = new Taisnsturis(5 , 6);

            t1.Laukums();
            t2.Laukums();
            */
        {
            Darbinieks darb = new Darbinieks();
            darb.Vards = "Pēteris";
            darb.Dzivesvieta = new Adrese();
            darb.Dzivesvieta.Valsts = "Latvija";
            darb.Dzivesvieta.Pilseta = "Rīga";
            darb.Dzivesvieta.Iela = "Rūpniecības iela";
            darb.Dzivesvieta.MajasNr = "15b";
            darb.Dzivesvieta.DzivoklaNr = 405;

            darb.AktualaNodala = new Nodala();
            darb.AktualaNodala.Nosaukums = "mārketinga nodaļa";
            darb.AktualaNodala.AtrasanasVieta = new Adrese();
            darb.AktualaNodala.AtrasanasVieta.Valsts = " Latvijā";
            darb.AktualaNodala.AtrasanasVieta.Pilseta = " Skrunda";
            darb.AktualaNodala.AtrasanasVieta.Iela = " Jūras iela";
            darb.AktualaNodala.AtrasanasVieta.MajasNr = " 4";
            darb.AktualaNodala.AtrasanasVieta.DzivoklaNr = 100;


            darb.IeprieksejaNodala = new Nodala();
            darb.IeprieksejaNodala.Nosaukums = "grāmatvedība";
            darb.IeprieksejaNodala.AtrasanasVieta = new Adrese();
            darb.IeprieksejaNodala.AtrasanasVieta.Valsts = " Latvijā";
            darb.IeprieksejaNodala.AtrasanasVieta.Pilseta = " Valmierā";
            darb.IeprieksejaNodala.AtrasanasVieta.Iela = " Rīgas iela";
            darb.IeprieksejaNodala.AtrasanasVieta.MajasNr = " 1";
            darb.IeprieksejaNodala.AtrasanasVieta.DzivoklaNr = 1;

            darb.Teikums1();
            darb.TeikumsDivi();

            Console.ReadLine();

            
            
        }
            
        
    }

    }
