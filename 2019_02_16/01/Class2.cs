using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_02_16
{
    class Class2
    {
        static void Main(string[] args)
        {
            for (int i = 2; i < 10; i++)
            {
                Console.WriteLine("구구단{0}단", i);
                for (int j = 1; j < 10; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
                Console.WriteLine();
            }

            int a_bb = 1;
            while (a_bb < 10)
            {
                Console.WriteLine("i_bb : {0}", a_bb);
                a_bb++;
            }

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("i : {0}", i);
            }

            int a_kk = 10;
            while (20 < a_kk)
            {
                Console.WriteLine("while문 kk : {0}", a_kk);
                a_kk++;
            }

            do
            {
                Console.WriteLine("dowhile문 kk : {0}", a_kk);
                a_kk++;
            } while (20 < a_kk);

            Console.ReadKey();
        }
    }
}
