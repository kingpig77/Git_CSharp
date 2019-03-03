using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CallByValue는 파라미터에 값을 전달(복사)해주는 개념
//CallByReference는 파라미터를 통해 값을 리턴 받아오는 개념

namespace Study_2019_03_02
{
    class MyClass2
    {
        static void ValSwap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static void RefSwap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        static void Main(string[] args)
        {
            int a = 111;
            int b = 999;
            //int temp = b;
            //b = a;
            //a = temp;
            ValSwap(a, b);//a값과 b값을 swap함수의 지역변수인 a와 b에 복사하여 연산함
            Console.WriteLine("a = {0} b = {1}", a, b);

            RefSwap(ref a,ref b);//main함수의 a와 b를 가져와 연산함
            Console.WriteLine("a = {0} b = {1}", a, b);


            int aa = 11;
            int bb = aa;
            aa = 22;
            Console.WriteLine("{0} {1}", aa, bb);

            int aaa = 11;
            ref int bbb =ref aaa;
            aaa = 22;
            Console.WriteLine("{0} {1}", aaa, bbb);
        }
    }
}
