using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_02_16_2
{
    class Class1
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];

            //배열 값채우고 출력
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = 14 + i;
                //Console.WriteLine("arr[{0}] : {1}", i, arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("arr[{0}] : {1}", i, arr[i]);
            }
            Console.WriteLine();

            //3배수 0초기화
            for (int i = 0; i < arr.Length; i++)
            {
                if (i % 3 == 0) arr[i] = 0;
                Console.WriteLine("arr[{0}] : {1}", i, arr[i]);
            }
            Console.WriteLine();

            //배열 옮기기
            int[] Brr = new int[100];
            for (int ii = 0; ii < 100; ii++)
            {
                Brr[ii] = ii;
                Console.WriteLine("Brr[{0}] = {1}", ii, Brr[ii]);
            }
            Console.WriteLine();
            int[] Crr = new int[100];
            for (int i = 0; i < 100; i++)
            {
                Crr[i] = Brr[99 - i];
                Console.WriteLine("Crr[{0}] = {1}", i, Crr[i]);
            }
            Console.WriteLine();

            //222는 몇번째 배열에 있는가?
            int[] App = { 34, 56, 12, 89, 120, 6, 8, 222, 67, 89, 110 };
            for (int i = 0; i < App.Length; i++)
            {
                if (App[i] == 222) Console.WriteLine("App[{0}] : {1}", i, App[i]);
            }
            Console.WriteLine();

            //66,99는 몇번째 배열에 있는가?
            int aaa = 0;
            int[] vvv = new int[100];
            for (int ii = 0; ii < 100; ii++)
            {
                if ((ii % 3) == 0)
                {
                    vvv[aaa] = ii;
                    aaa++;
                }
            }
            for (int i = 0; i < 100; i++)
            {
                if (vvv[i] == 66) Console.WriteLine("vvv[{0}] : {1}", i, vvv[i]);
                if (vvv[i] == 99) Console.WriteLine("vvv[{0}] : {1}", i, vvv[i]);
            }
            Console.WriteLine();

            //최소값 최대값 출력
            int[] a_kk = { 23, 45, 12, 67, 34, 77, 103, 3, 6, 7, 9, 11, 65, 204, 33, 56 };
            int min = 10000;
            int max = 0;
            for (int i = 0; i < a_kk.Length; i++)
            {
                if (a_kk[i] > max) max = a_kk[i];
                else if (a_kk[i] < min) min = a_kk[i];
            }
            Console.WriteLine("최소값 : {0}, 최대값 : {1}", min, max);

            Console.ReadKey();


        }
    }
}
