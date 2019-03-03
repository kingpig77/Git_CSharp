using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//C#에서 구조체는 Value타입
//C#에서 클래스는 Reference타입

namespace Study_2019_03_02
{
    class MyClass
    {
        struct struct_Student
        {
            public int Kor;
            public int Eng;
            public int Math;
            public int Total;
            public int Avg;

            public void Reset()
            {
                Kor = 0; Eng = 0; Math = 0; Total = 0; Avg = 0;
            }
        }
        class class_Student
        {
            public int Kor;
            public int Eng;
            public int Math;
            public int Total;
            public int Avg;

            public void Reset()
            {
                Kor = 0; Eng = 0; Math = 0; Total = 0; Avg = 0;
            }
        }

        static void Structjumsu(struct_Student a_std)
        {
            a_std.Kor = 23;
            a_std.Eng = 33;
            a_std.Math = 12;
            a_std.Total = a_std.Kor + a_std.Eng + a_std.Math;
            a_std.Avg = a_std.Total / 3;
        }

        static void Classjumsu(class_Student a_std)
        {
            a_std.Kor = 23;
            a_std.Eng = 33;
            a_std.Math = 12;
            a_std.Total = a_std.Kor + a_std.Eng + a_std.Math;
            a_std.Avg = a_std.Total / 3;
        }

        static void Main(string[] args)
        {
            struct_Student a_stt = new struct_Student();
            a_stt.Reset();
            Structjumsu(a_stt);
            Console.WriteLine("구조체 : 국어{0} 영어{1} 수학{2} 총점{3} 평균{4}",
                a_stt.Kor, a_stt.Eng, a_stt.Math, a_stt.Total, a_stt.Avg);

            class_Student a_css = new class_Student();
            a_css.Reset();
            Classjumsu(a_css);
            Console.WriteLine("구조체 : 국어{0} 영어{1} 수학{2} 총점{3} 평균{4}",
                a_css.Kor, a_css.Eng, a_css.Math, a_css.Total, a_css.Avg);

            Console.ReadKey();
        }
    }
}
