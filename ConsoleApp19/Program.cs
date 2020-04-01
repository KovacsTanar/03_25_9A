using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Feladat1();
            Feladat2();
            Feladat3();

            Console.ReadKey();
        }

        static void Feladat1()
        {
            
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("3^ {0} = {1}", i, Math.Pow(3, i));
            }
           
        }

        static void Feladat2()
        {
            Console.WriteLine("--------------------------------------");
            Random rnd = new Random();
            int db10 = 0;
            for (int i = 0; i < 40; i++)
            {
                int szam = rnd.Next(10, 100);
                Console.Write("{0} ",szam);
                if (szam % 10 == 0)
                    db10++;
            }

            Console.WriteLine("\nEnnyi 10-zel osztható szám van közöttük: {0}",db10);
        }

        static void Feladat3()
        {
            Console.WriteLine("--------------------------------------");
            Random rnd = new Random();

            Console.WriteLine("\nKérek egy pozitiv, egész számot!");
            int bekertSzam = Convert.ToInt32(Console.ReadLine());

            double osszeg = 0;

            Console.WriteLine("\nA számok:\n");

            for (int i = 0; i < bekertSzam; i++)
            {
                double szam = (double)rnd.Next(1000, 2001) / 100;
                Console.Write("{0:0.00} ",szam);
                osszeg += szam;
            }

            double atlag = osszeg / bekertSzam;

            Console.WriteLine("\n\nAz átlag: {0:0.00}",atlag);
           
        }
    }
}
