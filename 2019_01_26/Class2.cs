using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Study_2019_01_26
{
    class Class2
    {
        static void Main(string[] args)
        {
            //정수
            byte a = 200;
            sbyte b = -125;
            short c = 30000;
            ushort d = 40000;
            int e = 100000000;
            uint f = 1000000000;
            long g = 10000000000000000L;
            ulong h = 10000000000000000000L;

            Console.WriteLine("a = " + a + ", b = " + b);
            Console.WriteLine("a = {0}, b = {1}", a, b);  // 서식문자 {~#} = %d
            Console.WriteLine("a = {0}, b = {1}, c = {2}, d = {3}", a, b, c, d);

            //실수
            float aa = 123.56789f;
            double bb = 1234.567890123;
            decimal cc = 1234.567890123456m;

            Console.WriteLine("aa = {0}, bb = {1}, cc = {2}", aa, bb, cc);

            //문자, 문자열
            char dd = '안';
            string ee = "녕하세요";
            string ff = dd + ee;
            Console.WriteLine("{0}{1} : {2}", dd, ee, ff);

            //논리형
            bool gg = true;
            bool hh = false;
            Console.WriteLine("gg = {0}, hh = {1}", gg, hh);

            //객체 자료형(object는 모든 데이터형의 조상 클래스)
            object a_aa = 1234567;
            object a_bb = 1234.56789;
            object a_cc = true;
            object a_dd = "안녕하세요";
            Console.WriteLine("a_aa = {0}, a_bb = {1}, a_cc = {2}, a_dd = {3}", a_aa, a_bb, a_cc, a_dd);

            //서식 지정자(format specifier)
            int a_xx = 123;
            int a_yy = 321;
            Console.WriteLine("{0} + {1} = {2}", a_xx, a_yy, a_xx + a_yy);

            //구구단 7단
            int dan = 7, su = 1;

            Console.WriteLine("구구단 7단");
            while (su < 10)
            Console.WriteLine("{0} * {1} = {2}", dan, su, dan * su++);
            //

            //1부터 5까지의 합을 구하는 과정과 결과를 출력
            int sum = 0, counter = 1;

            Console.WriteLine("<1부터 5까지의 합>");
            Console.WriteLine("{0} + {1} = {2}", sum, counter, sum += counter++);
            Console.WriteLine("{0} + {1} = {2}", sum, counter, sum += counter++);
            Console.WriteLine("{0} + {1} = {2}", sum, counter, sum += counter++);
            Console.WriteLine("{0} + {1} = {2}", sum, counter, sum += counter++);
            Console.WriteLine("{0} + {1} = {2}", sum, counter, sum += counter);
            //
            Console.ReadKey();
        }
    }
}
