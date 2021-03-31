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

        }

        public static void Somma()
        {
            int add1 = 10;
            int add2 = 20;
            int  somma = add1 + add2;

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(somma);
            }

        }

        public static void StampareAVideoTabellina()
        {

        }
    }
}
