using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_02_09_2
{
    class Class1
    {
        static void Main(string args)
        {
            int money = 10000;
            Console.WriteLine("주사위게임");//이기면 점수오름 지면 깎임
            while (true) {
                Console.WriteLine("1. 홀수 2.짝수 중 하나의 번호를 선택");
                Console.Write(">> ");
                int a_user = int.Parse(Console.ReadLine());

                Random a_rand = new Random();
                int j_num = a_rand.Next(1, 7);

                if (j_num % 2 == 0)
                {
                    if(a_user == 2)
                    {
                        Console.WriteLine("맞추셨습니다.");
                        money += 500;
                        Console.WriteLine("보유게임머니 {0}원", money);
                    }
                }

            }
        }
    }
}
