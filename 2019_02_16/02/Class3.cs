using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Study_2019_02_16_2
{
    class Class3
    {
        static void Main(string[] args)
        {
            string str = "";
            string str2 = null;
            string str3 = string.Empty;

            string strtxt = "asdfgh";
            string a_Mystr = strtxt.Substring(2, 2);

            Console.WriteLine(a_Mystr);

            string strtxt2 = "abcdefgh";
            string a_Mytest = strtxt2.Substring(3);
            Console.WriteLine(a_Mytest);

            string a_sss = "아기상어,12,바다수족관";
            Console.WriteLine("원본 문자열 : " + a_sss);
            string[] strArr = a_sss.Split(',');
            Console.WriteLine("이름 : " + strArr[0]);
            Console.WriteLine("나이 : " + strArr[1]);
            Console.WriteLine("주소 : " + strArr[2]);

            string a_ggg = "홍길동,23,경기도홍길동집";
            string[] strArr2 = a_ggg.Split(',');
            Console.WriteLine("이름 : " + strArr2[0]);
            Console.WriteLine("나이 : " + strArr2[1]);
            Console.WriteLine("주소 : " + strArr2[2]);

            string s1 = "Hello I'm 학생";
            string s2 = "학생";
            if (s1.Contains(s2) == true)
            {
                Console.WriteLine("포함");
            }
            else
            {
                Console.WriteLine("불포함");
            }

            Console.Write("우리나라의 수도는 어디입니까? : ");
            string a_input = Console.ReadLine();
            if (a_input.Contains("서울") == true)
            {
                Console.WriteLine("맞습니다");
            }
            else
            {
                Console.WriteLine("틀렸습니다");
            }
            
            
            string str11 = "This is test";
            string str22 = "This is test";

            if(str11 == str22)
            {
                Console.WriteLine(str11 + " and " + str22 + " are equal");
            }
            if (string.Compare(str11, str22) == 0)
            {
                Console.WriteLine(str11 + " and " + str22 + " are equal");
            }
            else
            {
                Console.WriteLine("두문장은같지않습니다");
            }

            string a_abc = "   안녕하세요   ";
            Console.WriteLine(a_abc);
            string a_Trim = a_abc.Trim();
            Console.WriteLine(a_Trim);

            string a_ppp = "동해물과백두산이마르고닳도록하느님이보우하사우리나라만세";
            int a_pos = a_ppp.IndexOf("마르고닳도록");
            Console.WriteLine(a_pos.ToString()); //문자열로변환
            int a_pos2 = a_ppp.IndexOf("이");
            Console.WriteLine(a_pos2);

            string a_uuu = "Krorea";
            int s16 = a_uuu.IndexOf("p");
            //왼쪽부터 첫번째 p위치없음 -> -1

            int s17 = a_uuu.IndexOf("r");
            int s18 = a_uuu.LastIndexOf("r");//오른쪽부터 r의위치

            Console.WriteLine("indexof : {0}, Lastindexof : {1}", s17, s18);

            
            Console.ReadKey();
        }
    }
}
