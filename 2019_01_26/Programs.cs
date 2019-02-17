using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//사용자 지정 수치 서식 문자열

namespace Study_2019_01_26_2
{
    class Programs
    {
        static void Main(string[] args)
        {
            int aa = 123456789;
            int bb = 987654321;
            string a_str = string.Format("{0:0,0} : {1:0,0}", aa, bb);
            Console.WriteLine("{0} : {1}", aa, bb);
            Console.WriteLine("{0:0,0} : {1:0,0}", aa, bb); //천단위에 쉼표
            Console.WriteLine(a_str);

            Console.WriteLine("{0:n} : {1:N}", aa, bb); //천단위에 쉼표 & 소수점 둘째자리표시
            Console.WriteLine("{0:n0} : {1:N0}", aa, bb); //천단위에 쉼표

            //소수점 자리표시
            float cc = 12.3456789f;
            Console.WriteLine("{0}",cc);
            Console.WriteLine("{0:0.0}", cc); //소수점 자리표시
            Console.WriteLine("{0:#.#}", cc); // 소수점 자리표시
            Console.WriteLine("{0:0.00}", cc);
            Console.WriteLine("{0:#.##}", cc);
            Console.WriteLine("{0:0.000}", cc);
            Console.WriteLine("{0:#.###}", cc);

            float dd = 34.12f;
            Console.WriteLine("{0:0.00000}", dd);//빈자리 0으로 채움
            Console.WriteLine("{0:#.#####}", dd);//빈자리 자름

            Console.ReadKey();
        }
    }
}
