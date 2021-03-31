using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Verifica_31_marzo
{
    class Program
    {
        
        static Thread t1;
        static Thread t2;
        static Thread t3;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(new ThreadStart(Somma));
            Thread t2 = new Thread(new ThreadStart(StampareAVideoTabellina));
            Thread t3 = new Thread(new ThreadStart(StampaAVideoStringa));

           
        }

        private  static void Somma()
        {
            int add1 = 10;
            int add2 = 20;
            int  somma = add1 + add2;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(somma);
            }

        }

        private  static void StampareAVideoTabellina()
        {
            int numero = 70;
            for(int i = 1; i < 11; i++)
            {
                Console.WriteLine(numero * i);
            }
        }

        private static void StampaAVideoStringa()
        {
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Siamo nell'anno 202" + i);
            }
        }


    }
}
