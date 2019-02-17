using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_02_16
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int num = 0; num < 10; num++)
            {
                Console.WriteLine("num : {0}", num);

            }
            Console.WriteLine();

            int a_i = 0;
            for (a_i = 0; a_i < 12; a_i++)
            {
                Console.WriteLine("a_i : {0}", a_i);
            }
            Console.WriteLine("for문 끝난후 a_i : {0}", a_i);

            Console.WriteLine();

            for (int ii = 1; ii < 10; ii++)
            {
                Console.WriteLine("ii : {0}", ii);
            }
            Console.WriteLine();

            for (int xx = 10; xx > 0; xx--)
            {
                Console.WriteLine("xx : {0}", xx);
            }
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
