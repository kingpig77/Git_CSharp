using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_2_9
{
    class Class4
    {
        static void Main(string[] args)
        {
            string user = "";
            string cpu = "";

            Console.WriteLine("가위바위보 게임");
            Console.WriteLine("1. 가위 2. 바위 3. 보 중 하나의 번호를 선택해주세요.");
            Console.Write(">> ");
            int a_user = int.Parse(Console.ReadLine());

            Random a_rand = new Random();
            int ai = a_rand.Next(1, 4);

            if (ai == 1) cpu = "가위";
            else if (ai == 2) cpu = "바위";
            else if (ai == 3) cpu = "보";

            if (a_user == 1) user = "가위";
            else if (a_user == 2) user = "바위";
            else if (a_user == 3) user = "보";

            Console.Write("User({0}) : Computer({1})", user, cpu);

            if (a_user == ai) Console.WriteLine("비기셨습니다.");
            else if (a_user > ai)
            {
                if (a_user - ai == 2) Console.WriteLine("패배하셨습니다.");
                else Console.WriteLine("승리하셨습니다.");
            }
            else if (a_user < ai)
            {
                if (ai - a_user == 2) Console.WriteLine("승리하셨습니다.");
                else Console.WriteLine("패배하셨습니다.");
            }

            Console.ReadKey();
        }
    }
}
