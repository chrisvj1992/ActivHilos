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
        public int terminado = 0;
        public Hilos()
        {
            Thread t = new Thread(Productor);

            t.Start();

            Thread t1 = new Thread(Consumidor);

            t1.Start();
        }



        bool puedeImprimir = false;
        void Productor()
        {
            for(i = 0; i < 10; i++) 
            {
                puedeImprimir = true;
                while(puedeImprimir == true){ }
            }
            terminado++;
        }

        void Consumidor()
        {
            while(i<10)
            {
                if(puedeImprimir == true)
                {
                    Console.WriteLine(i);
                    puedeImprimir = false;  
                }
            }
            terminado++;
        }
    }
}
