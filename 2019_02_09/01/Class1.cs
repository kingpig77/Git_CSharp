using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_2_9
{
    class Class1
    {
        static void Main(string[] args)
        {
            //Console.Write("이름을 입력하세요 ");

            //string a_name = Console.ReadLine(); //문자열 한줄 입력받음
            //Console.WriteLine("이름 : {0}", a_name);

            //Console.Write("숫자하나를 입력하세요 ");
            //int a_i = int.Parse(Console.ReadLine());//숫자 한줄 입력받음
            //Console.WriteLine("숫자 : {0}", a_i);

            //int a, b;
            //Console.Write("숫자 하나 입력 : ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("숫자 하나 입력 : ");
            //b = int.Parse(Console.ReadLine());
            //Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            //Console.WriteLine("{0} - {1} = {2}", a, b, a - b);
            //Console.WriteLine("{0} * {1} = {2}", a, b, a * b);
            //Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            //Console.WriteLine("{0} % {1} = {2}", a, b, a % b);

            Random a_i = new Random();
            int a_rand = a_i.Next(1, 7);
            Console.WriteLine("{0}", a_rand);

            int e = 0;
            Console.WriteLine("{0}", e++);
            int d = 0;
            Console.WriteLine("{0}", ++d);

            Console.WriteLine("");
            int a_xx = 10;
            a_xx += 5;

            bool is_true = false;

            is_true = 50 < 30 || 80 > 10;
            Console.WriteLine("{0}", is_true);

            Console.WriteLine(40 >= 60);

            Console.ReadKey();
        }
    }
}
