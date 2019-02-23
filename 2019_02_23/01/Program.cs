using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//enum 코드의 가독성을 좋게만드는 문법
//숫자형타입과 호환가능, int형변환이 가능

public enum GawiBowBo
{
    Gawi = 1,
    Bawi = 2,
    Bo = 3
};

namespace Study_2019_02_23
{
    class Program
    {
        enum City
        {
            Seoul,
            Deajun,
            Busan,
            Jeju
        }
        static void Main(string[] args)
        {
            City myCity = City.Seoul;
            int a_WinCount = 0;
            int a_LostCount = 0;
            int a_MuCount = 0;
            int a_Money = 1000;

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green; //콘솔 글씨색을 녹색으로...
                Console.WriteLine("<가위, 바위, 보 게임>");
                Console.WriteLine("User 상태 {0}골드 : {1}승 {2}패 {3}무 (3패시 게임종료)", a_Money, a_WinCount, a_LostCount, a_MuCount);
                Console.ForegroundColor = ConsoleColor.Gray;  //콘솔 글씨 원래색으로 돌리기
                Console.Write("1, 가위  2,바위  3,보  99, 게임종료 : ");
                string a_Inputstr = Console.ReadLine();

                if (a_Inputstr == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red; //콘솔 글씨색을 녹색으로...
                    Console.WriteLine("숫자를 입력해 주세요.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                else
                {
                    int i = 0;
                    bool result = int.TryParse(a_Inputstr, out i);
                    if (result == false)
                    {
                        Console.ForegroundColor = ConsoleColor.Red; //콘솔 글씨색을 녹색으로...
                        Console.WriteLine("숫자를 입력해 주세요.");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                }

                int a_UserSel = int.Parse(a_Inputstr);

                if (a_UserSel == 99)
                    break;

                if (a_UserSel < 1 || 3 < a_UserSel)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("1 또는 2 또는 3중에 하나를 입력해 주세요.");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                //랜덤 값 얻기
                Random a_Rd = new Random();
                int a_ComSel = a_Rd.Next(1, 4); //1부터 4사이의 랜덤한 값(4는 제외)

                string a_StrUser = "가위";
                if (a_UserSel == (int)GawiBowBo.Bawi) //2)
                {
                    a_StrUser = "바위";
                }
                else if (a_UserSel == (int)GawiBowBo.Bo) //3)
                {
                    a_StrUser = "보";
                }
                string a_StrCom = "가위";
                if (a_ComSel == (int)GawiBowBo.Bawi) //2)
                {
                    a_StrCom = "바위";
                }
                else if (a_ComSel == (int)GawiBowBo.Bo) //3)
                {
                    a_StrCom = "보";
                }

                if (a_UserSel == a_ComSel)
                {
                    Console.WriteLine("User({0}) : Computer({1}) 비겼습니다.",
                        a_StrUser, a_StrCom);
                    a_MuCount++;
                }
                else if (a_UserSel == (int)GawiBowBo.Gawi
                        && a_ComSel == (int)GawiBowBo.Bo)
                //else if(a_UserSel == 1 && a_ComSel == 3)
                {
                    Console.WriteLine("User({0}) : Computer({1}) 승리하셨습니다. + 100골드", a_StrUser, a_StrCom);
                    a_WinCount++;
                    a_Money = a_Money + 100;
                }
                else if (a_UserSel == (int)GawiBowBo.Bawi
                        && a_ComSel == (int)GawiBowBo.Gawi)
                //else if(a_UserSel == 2 && a_ComSel == 1)
                {
                    Console.WriteLine("User({0}) : Computer({1}) 승리하셨습니다. + 100골드", a_StrUser, a_StrCom);
                    a_WinCount++;
                    a_Money = a_Money + 100;
                }
                else if (a_UserSel == (int)GawiBowBo.Bo
                        && a_ComSel == (int)GawiBowBo.Bawi)
                //else if(a_UserSel == 3 && a_ComSel == 2)
                {
                    Console.WriteLine("User({0}) : Computer({1}) 승리하셨습니다. + 100골드", a_StrUser, a_StrCom);
                    a_WinCount++;
                    a_Money = a_Money + 100;
                }
                else
                {
                    Console.WriteLine("User({0}) : Computer({1}) 패배하셨습니다.  -200골드", a_StrUser, a_StrCom);
                    a_LostCount++;
                    a_Money = a_Money - 200;

                    if (a_Money <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("보유하신 골드를 모두 소진했습니다.");
                        Console.WriteLine("Enter를 누르면 게임종료...");
                        Console.ReadKey();
                        break;
                    }

                    if (3 <= a_LostCount)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("3패를 당해서 종료됩니다.");
                        Console.WriteLine("Enter를 누르면 게임종료...");
                        Console.ReadKey();
                        break;
                    }
                }

                Console.WriteLine("Enter를 누르면 게임 계속 진행...");
                Console.ReadKey();
                Console.Clear();
            }//while(true)
        }
    }
}
