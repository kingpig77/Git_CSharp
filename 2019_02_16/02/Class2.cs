using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_02_16_2
{
    class Class2
    {
        static void Main(string[] args)
        {
            int[] a = new int[3];
            a[0] = 10;
            a[1] = 20;
            a[2] = 30;

            int[,] b = new int[2, 3];
            b[0, 0] = 10;
            b[0, 1] = 20;
            b[0, 2] = 30;
            b[1, 0] = 40;
            b[1, 1] = 50;
            b[1, 2] = 60;

            for (int xx = 0; xx < 2; xx++)
            {
                for (int yy = 0; yy < 3; yy++)
                {
                    Console.WriteLine("b[{0} , {1}] : {2}", xx, yy, b[xx, yy]);
                }
            }

            int[,,] c = new int[2, 3, 4];

            int[] nums = new int[5];
            nums[0] = 11;
            nums[1] = 22;
            nums[2] = 33;
            nums[3] = 44;
            nums[4] = 55;
            for (int idx = 0; idx < nums.Length; idx++)
            {
                Console.WriteLine(nums[idx]);
            }
            foreach (int dd in nums)
            {
                Console.WriteLine(dd);
            }

            int[] vvv = { 7, 61, 12, 32, 3, 76, 23, 43 };//배열안 모든값을 더하고 평균구하여출력
            int sum = 0;
            foreach (int s in vvv) sum += s;
            Console.WriteLine("Total : {0}, Avg : {1}", sum, sum / vvv.Length);

            Console.ReadKey();
        }
    }
}
