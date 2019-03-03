using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//메소드 : c나 c++에서는 함수라고도 함
//접근지정자 리턴형 함수이름(데이터형 매개변수, 데이터형 매개변수)
//{
//  실행코드
//}

namespace Study_2019_03_02
{
    class Class2
    {
        // 인스턴스메소드(인스턴스 객체가 있어야 호출되는 메소드)
        public int Sum(int a, int b)
        {
            int c = a + b;
            return c;
        }

        // 클래스메소드(클래스이름.함수() : 바로 호출할수있다)
        static public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }

    }
    class Program
    {
        //if 같은소속
        //클래스in클래스 그냥가능
        //클래스in인스턴스 그냥가능
        //인스턴스in클래스 객체생성
        //인스턴스in인스턴스 그냥가능
        void Hap(int kor, int eng, int math)//인스턴스함수(메소드)
        {
            int a_hap = kor + eng + math;
            Console.WriteLine("총점 : {0}", a_hap);
        }

        static void AABB(int Avg)//클래스함수(메소드)
        {
            Console.WriteLine("평균 : {0}", Avg);
        }

        void MyPrint()//void : return안해도댐
        {
            Hap(1, 2, 3);//static이 없기때문에 같은 일반함수끼리는 호출 십가능
            AABB(123);//클래스함수는 인스턴스함수에서 그냥 호출가능 (Program.AABB로해도되고 생략도가능)
        }

        static void Main(string[] args)//static이 붙으면 클래스소속함수이기때문에
        {
            Program list = new Program();//static을 쓰지않을경우 클래스가같아도 객체생성해야함
            list.Hap(1, 22, 33);
            AABB(123); //OR
            Program.AABB(223);
            //Class2 a_list = new Class2();
            //int Result = a_list.Sum(111, 222);

            //Console.WriteLine("Result : {0}", Result);

            //int Result2 = Class2.Add(777, 123);
            //Console.WriteLine("Result2 : {0}", Result2);
            //Console.ReadKey();
        }
    }
}
