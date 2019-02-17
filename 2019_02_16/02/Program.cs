using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_02_16_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bdd = new int[2];

            int[] arr = new int[100];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;

            for (int i = 0; i < 100; i++)
            {
                arr[i] = i + 1;
                Console.WriteLine("{0}", arr[i]);
            }
            Console.WriteLine();

            int[] bbb = new int[987];
            for (int i = 0; i < bbb.Length; i++)
            {
                bbb[i] = i + 1;
                Console.WriteLine("{0}", bbb[i]);
            }
            Console.WriteLine();

            int[] arrs = new int[10];
            int[] arrr;
            arrr = new int[20];//명시적 선언

            int[] arss = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };//암시적 선언
            for (int i = 0; i < arss.Length; i++)
            {
                Console.WriteLine("{0}", arss[i]);
            }
            Console.WriteLine();

            int[] a_rr = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            int[] a_rrs;
            a_rrs = new int[] { 10, 20, 30, 40, 50 };//명시적이며 암시적인 선언
            for (int xx = 0; xx < a_rrs.Length; xx++)
            {
                Console.WriteLine("{0} = {1}", xx, a_rrs[xx]);
            }
        }
    }
}
