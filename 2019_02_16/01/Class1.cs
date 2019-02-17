using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_02_16
{
    class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("출력할 구구단의 단을 입력해 주세요 : ");
            int dan = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", dan, i, dan * i);
            }
            Console.ReadKey();
        }
    }
}
