using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//class
//멤버변수(필드), 멤버메서드, 속성, 이벤트등을 멤버로 포함하는 소프트웨어 단위,
//보통 이 클래스 정의로부터 객체(Object)를 생성해서 사용하게된다.
//접근제한자(Access Modifier) public,protected,private

//public : 각 속성을 가지는 멤버는 외부로 공개하고, 누구나 알고 쓸수있고 함수의 경우는 호출할 수 있다.
//class가 자신의 속성이나 동작을 외부로 공개하는 수단이 되어 public 멤버를 소위 인터페이스라고한다.

//private : 이 속성을 가지는 멤버는 외부에서 엑세스 할수 없으며, 내부 멤버 함수만 엑세스할수있다.
//외부에서는 private멤버를 읽을수 없고 존재 자체도 알려지지 않는다.

//protected private속성과 마찬가지로 외부에서는 엑세스 할수없으나, 단 상속된 파생클래스는 이 멤버를 엑세스할수있다.
//private멤버는 파생 클래스에서도 접근할수 없으며 오로지 자신만이 이 멤버를 접근할 수 있다는 점이 다르다.

public class Character
{
    public string Name;
    private int Level;
    protected int MaxHp;
    public int Cost;
    int Speed = 0; //접근제한자를 생략할경우 기본적으로 private속성이 됨

    public int Levels
    {//속성 <- 외부에서 접근할 수 없는 변수들의 접근권한을 부여해주는함수
        get => Level;
        set => Level = value;
    }

    public Character() // 생성자 함수(객체생성시 한번 호출하고 주로 멤버변수들을 초기화해주는용도로 사용)
    {
        Name = "";
        Level = 1;
        MaxHp = 100;
        Cost = 0;
    }

    public void PrintInfo()
    {
        Console.WriteLine("이름({0}) 레벨({1}) 최대체력({2}) 가격({3})", Name, Level, MaxHp, Cost);
    }
}

namespace Study_2019_02_23
{
    class Class2
    {
        static void Main(String[] args)
        {
            Character Ch = new Character();
            Ch.Name = "엘프";
            Ch.Cost = 1200;
            Ch.PrintInfo();

            Console.ReadKey();
        }
    }
}
