using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_2_9
{
    class Class3
    {
        static void Main(string[] args)
        {
            int answer = 0;
            Console.WriteLine("홀짝 맞추기");

            Console.Write("1. 홀수 2. 짝수 다음중 하나의 번호를 선택하세요. ");
            int a_useridx = int.Parse(Console.ReadLine());

            Random a_rand = new Random();
            int a_random = a_rand.Next(1, 100);
            if (a_random % 2 == 0 && a_useridx == 2)
            {
                Console.WriteLine("{0}은(는) 짝수입니다.", a_random);
            }
            else if (a_random % 2 != 0 && a_useridx == 1)
            {
                Console.WriteLine("{0}은(는) 홀수입니다.", a_random);
            }
            else
            {
                Console.Write("오답, {0}은(는) ", a_random);
                if (a_useridx == 1) Console.WriteLine("짝수입니다.");
                else Console.WriteLine("짝수입니다.");
            }
        }
    }
}
