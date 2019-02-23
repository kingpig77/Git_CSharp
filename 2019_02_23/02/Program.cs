using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//클래스변수와 인스턴스변수
//클래스 변수, 클래스 함수 : static 키워드를 붙이면 된다.
//                         static 키워드가 붙게되면 객체생성없이 클래스이름.변수명

namespace Study_2019_02_23_2
{
    class User
    {
        public string Name; // 인스턴스 변수
        public int Level;
        public int Gold;

        static public int ImageNum = 0; // 클래스변수

        public void Print() // 인스턴스 메소드
        {
            Console.WriteLine(ImageNum);
        }
        
        static public void StPrint() // 클래스 메소드
        {
            Console.WriteLine(ImageNum);
            //static함수 내에서는 static변수나 함수만 사용할수있다.
        }
    }
    class Program
    {
        static void Main(string[] args) // static이 왜붙었는가? 
        {
            User aa = new User(); // 객체 선언
            aa.Name = "강아지"; // 인스턴스 변수
            aa.Print(); // 인스턴스 메소드

            User bb = new User(); // 객체 선언
            bb.Level = 10; // 인스턴스 변수
            bb.Print(); // 인스턴스 메소드

            User.ImageNum = 11; // Use Class Var (객체없이 사용할수있는변수)


            Console.ReadKey();
            
        }
    }
}
