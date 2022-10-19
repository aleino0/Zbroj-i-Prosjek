using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZbrojiProsjek
{
    public class KlasaC
    {
        //metode
        public static int Zbroj(int[] brojevi)
        {
            int zbroj = 0;
            for (int i = 0; i < 5; i++)
            {
                zbroj += brojevi[i];
            }
            return zbroj;
        }

        public static double Prosjek(int[] brojevi)
        {
            double prosjek = 0;
            for (int i = 0; i < 5; i++)
            {
                prosjek += brojevi[i];
            }
            prosjek = prosjek / 5;
            return prosjek;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] brojevi=new int[5];

            Console.WriteLine("Unesite 5 cijelih brojeva");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Unesite broj: ");

                brojevi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Zbroj upisanih brojeva je: " + KlasaC.Zbroj(brojevi));
            Console.WriteLine("Prosjek upisanih brojeva je: " + KlasaC.Prosjek(brojevi));

            Console.ReadKey();
        }
    }
   
    

}
