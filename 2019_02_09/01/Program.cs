using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_2_9
{
    class Program
    {
        static int abc = 10; //클래스소속 정적변수, 클래스의 멤버변수
        int cba = 0; //클래스소속 지역변수, 클래스의 멤버변수

        void Test()
        {
            int cba = 11;
            Console.WriteLine("cba = {0}", cba);//가까이있는쪽 우선
        }
        static void Main(string[] args)
        {
            int ai = 0;
            ai = 12;
            {
                ai = 33;
                Console.WriteLine("ai = {0}", ai);
            }
            {
                int abc = 10;
                Console.WriteLine("abc = {0}", abc);//소속이 다른 같은이름의 지역변수들이 있을때 가까이있는쪽 우선
            }


            Console.ReadKey();
        }
    }
}
