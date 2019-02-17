using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_02_09_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 하나를 입력 : ");
            int a_input = int.Parse(Console.ReadLine());

            switch (a_input%2)
            {
                case 0:
                    Console.WriteLine("짝수입니다."); break;
                case 1:
                    Console.WriteLine("홀수입니다."); break;
            }

            if (a_input % 2 == 0) Console.WriteLine("짝수입니다.");
            else if (a_input % 2 == 1) Console.WriteLine("홀수입니다.");

            Console.Write("오늘의 요일을 입력해주세요.");
            string a_day = Console.ReadLine();

            switch (a_day)
            {
                case "일":
                    Console.WriteLine("오늘은 {0}요일입니다.", a_day); break;
                case "월":
                    Console.WriteLine("오늘은 {0}요일입니다.", a_day); break;
                case "화":
                    Console.WriteLine("오늘은 {0}요일입니다.", a_day); break;
                case "수":
                    Console.WriteLine("오늘은 {0}요일입니다.", a_day); break;
                case "목":
                    Console.WriteLine("오늘은 {0}요일입니다.", a_day); break;
                case "금":
                    Console.WriteLine("오늘은 {0}요일입니다.", a_day); break;
                case "토":
                    Console.WriteLine("오늘은 {0}요일입니다.", a_day); break;
                default:
                    Console.WriteLine("해당하는요일을 입력해주세요"); break;
            }

            if (a_day == "일") Console.WriteLine("오늘은 {0}요일입니다.", a_day);
            else if (a_day == "월") Console.WriteLine("오늘은 {0}요일입니다.", a_day);
            else if (a_day == "화") Console.WriteLine("오늘은 {0}요일입니다.", a_day);
            else if (a_day == "수") Console.WriteLine("오늘은 {0}요일입니다.", a_day);
            else if (a_day == "목") Console.WriteLine("오늘은 {0}요일입니다.", a_day);
            else if (a_day == "금") Console.WriteLine("오늘은 {0}요일입니다.", a_day);
            else if (a_day == "토") Console.WriteLine("오늘은 {0}요일입니다.", a_day);


            Console.ReadKey();
        }
    }
}
