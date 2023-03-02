    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ActivHilos
{
    internal class Hilos
    {
        int a, i;
        public Hilos()
        {
            Thread t = new Thread(Imprime);

            t.Start();

            Thread t1 = new Thread(Imprime1);

            t1.Start();
        }



        public void Imprime()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + "Hilo 1");
            }
        }

        public void Imprime1()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i + "Hilo 2");
            }
        }
    }
}
