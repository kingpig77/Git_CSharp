using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Student //c#의 구조체는 멤버변수들과 멤버메서드들로 이루어져있다
{
    public string m_Name; //멤버변수
    public int m_Kor;
    public int m_Eng;
    public int m_Math;
    public int m_Total;
    public float m_Avg;

    public void CacTotal() //멤버메서드
    {
        m_Total = m_Kor + m_Eng + m_Math;
        m_Avg = m_Total / 3.0f;
    }
    public void PrintInfo()
    {
        Console.WriteLine("이름 {0} 국어{1} 영어{2} 수학{3} 총점{4} 평균{5}", m_Name, m_Kor, m_Eng, m_Math, m_Total, m_Avg);
    }
}

//for(5명)
//1번 학생의 이름을 입력해 주세요 : ???
//국어점수 : ???
//영어점수 : ???
//수학점수 : ???

//<학생성적리스트>
//1번 이름({0}) : 국어({1}) 영어({2}) 수학({3}) 총점({4}) 평균({5:0.00})
//2번 이름({0}) : 국어({1}) 영어({2}) 수학({3}) 총점({4}) 평균({5:0.00})
//3번 이름({0}) : 국어({1}) 영어({2}) 수학({3}) 총점({4}) 평균({5:0.00})
//4번 이름({0}) : 국어({1}) 영어({2}) 수학({3}) 총점({4}) 평균({5:0.00})
//5번 이름({0}) : 국어({1}) 영어({2}) 수학({3}) 총점({4}) 평균({5:0.00})

public struct School
{
    public string Name;
    public int Math;
    public int Eng;
    public int Kor;
    public int Total;
    public float Avg;

    public void Cac()
    {
        Total = Math + Eng + Kor;
        Avg = Total / 3.0f;
    }
    public void Print()
    {
        Console.WriteLine("이름({0}) : 국어({1}) 영어({2}) 수학({3}) 총점({4}) 평균({5:0.00})", Name, Kor, Eng, Math, Total, Avg);
    }

}

namespace Study_2019_02_23
{
    class Class1
    {
        static void Main(String[] args)
        {
            Student a_StInfo = new Student();
            a_StInfo.m_Name = "아기상어";
            a_StInfo.m_Kor = 57;
            a_StInfo.m_Eng = 78;
            a_StInfo.m_Math = 87;
            a_StInfo.CacTotal();

            Console.WriteLine("이름 {0} 국어{1} 영어{2} 수학{3} 총점{4} 평균{5}", a_StInfo.m_Name, a_StInfo.m_Kor, a_StInfo.m_Eng, a_StInfo.m_Math, a_StInfo.m_Total, a_StInfo.m_Avg);
            Console.ReadKey();

            Student[] a_Array = new Student[5];

            for (int i = 0; i < a_Array.Length; i++)
            {
                a_Array[i].m_Name = "아기상어";
                a_Array[i].m_Kor = i + 2;
                a_Array[i].m_Eng = i + 3;
                a_Array[i].m_Math = i + 4;
                a_Array[i].CacTotal();
                a_Array[i].PrintInfo();
            }

            School[] Array = new School[5];
            float Ttoal = 0.0f;
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write("{0}번 학생의 이름을 입력해 주세요 : ", i + 1);
                Array[i].Name = Console.ReadLine();
                Console.Write("국어 점수 : ");
                Array[i].Kor = int.Parse(Console.ReadLine());
                Console.Write("영어 점수 : ");
                Array[i].Eng = int.Parse(Console.ReadLine());
                Console.Write("수학 점수 : ");
                Array[i].Math = int.Parse(Console.ReadLine());

                Array[i].Cac();
                Ttoal += Array[i].Avg;
            }
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i].Print();
            }
            Console.WriteLine("학생수 : {0}명 반평균 : {1:0.00}", Array.Length, Ttoal / Array.Length);
        }
    }
}
