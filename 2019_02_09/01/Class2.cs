using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_2_9
{
    class Class2
    {
        static void Main(string[] args)
        {
            int ii = 50;
            int tt = 60;
            if (ii < tt)
            {
                Console.WriteLine("ii < tt 가 맞습니다.");
            }

            Console.WriteLine("정수 하나를 입력 ");
            int a_i = int.Parse(Console.ReadLine());

            if (a_i == 7)
            {
                Console.WriteLine("input 7");
            }
            if (a_i == 8)
            {
                Console.WriteLine("input 8");
            }
            if (a_i == 9)
            {
                Console.WriteLine("input 9");
            }
            if (a_i == 9)
            {
                Console.WriteLine("9맞음");
            }

            if (a_i == 7)
            {
                Console.WriteLine("7입력");
            }
            else if (a_i == 8)
            {
                Console.WriteLine("8입력");
            }
            else if (a_i == 9)
            {
                Console.WriteLine("9입력");
            }
            else
            {
                Console.WriteLine("아무것도아님");
            }




            Console.ReadKey();
        }
    }
}
