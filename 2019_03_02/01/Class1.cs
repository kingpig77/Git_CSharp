using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_03_02
{
    class Class1
    {
        static void Hap(int kor, int eng, int math)
        {
            int a_hap = kor + eng + math;
            
            Console.WriteLine("총점 : {0}", a_hap);
        }

        static int Division(int a, int b)
        {
            if (b <= 0)
                return 0;

            return a / b;
        }

        static void Main(string[] args)
        {
            int a = 22;
            int b = 10;
            if (0 < b)
            {
                int c = Division(a, b);
                Console.WriteLine("C : {0}", c);
            }

            int d = 44;
            int e = 22;
            if (0 < e)
            {
                Console.WriteLine("B : {0}", Division(d, e));
            }

            Hap(11, 22, 33);
            Console.ReadKey();
        }
    }
}
