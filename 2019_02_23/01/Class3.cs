using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C# namespace네임스페이스
//같은 클래스 이름의 중복을 피하기 위해 클래스들을 그룹화시켜줄 때 사용하는 키워드


namespace Study_1 //다른 네임스페이스
{

    public class Student
    {
        public string Name; //멤버변수
        public int Kor;

        public void PrintInfo()
        {
            Console.WriteLine("이름({0}) 국어점수({1})", Name, Kor);
        }
    }
}

namespace Study_2 //다른 네임스페이스
{
    public class Student
    {
        public string Name;
        public int Math;

        public void OutPrintInfo()
        {
            Console.WriteLine("이름({0}) 수학점수({1})", Name, Math);
        }
    }
}
namespace Study_2019_02_23
{
    class Class3
    {
        static void Main(String[] args)
        {
            Study_1.Student St = new Study_1.Student();
            St.Name = "강아지";
            St.Kor = 85;
            St.PrintInfo();

            Study_2.Student Stt = new Study_2.Student();
            Stt.Name = "고양이";
            Stt.Math = 35;
            Stt.OutPrintInfo();

            Console.ReadKey();
        }
    }
}
