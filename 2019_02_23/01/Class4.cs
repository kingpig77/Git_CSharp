using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Study_2;
//네임스페이스 그룹으로 묶여있는 클래스를 사용하는 2가지 방법
//1 클래스이름 앞에 네임스페이스 전부를 작성해 주는방법
//2 프로그램 맨 윗단에 해당 using을 사용하여 C#.cs파일에서 사용하고자하는 네임스페이스를 한번 설정해주고
//이후에 해당 파일내에서 네임스페이스 없이 직접 클래스를 사용하는방법

namespace Study_2019_02_23
{
    class Class4
    {
        static void Main(String[] args)
        {
            Study_1.Student St = new Study_1.Student();
            St.Name = "아기상어";
            St.Kor = 81;
            St.PrintInfo();

            Student Stt = new Student();
            Stt.Name = "고양이";
            Stt.Math = 91;
            Stt.OutPrintInfo();

            

            Console.ReadKey(); 
        }
    }
}
