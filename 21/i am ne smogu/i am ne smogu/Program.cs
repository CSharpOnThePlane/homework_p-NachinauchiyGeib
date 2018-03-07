using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace i_am_ne_smogu
{
    class Program
    {
        static void Main(string[] args)
        {
            int schetchik = 0;
            for (int i = 0; i <20; i++)
            {
                
                Console.WriteLine("Довой пегроем в икру. Нозови свай раст и я...");
                string g = Console.ReadLine();
                int Rost_Comrada = int.Parse(g);
                if (Rost_Comrada > 160)
                {
                     Console.WriteLine("Расстрелять");
                    schetchik++;
                }
                else
                {
                    Console.WriteLine("Ти пака жив...");
                }
                

            }
            Console.WriteLine(schetchik);





        }
    }
}
