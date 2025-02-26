using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace study9
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 5; // 0101
            //int y = 3; // 0011

            //Console.WriteLine(x & y); // AND:1 (0001)
            //Console.WriteLine(x | y); // OR: 7 (0111)
            //Console.WriteLine(x ^ y); // XOR: 6 (0110)
            //Console.WriteLine(~x); // NOT: -6 (1111 1111 1111 1111 1111 1111 1111 1010) 
            //string NOTxResult = Convert.ToString(~x, 2);
            //Console.WriteLine(NOTxResult); // 11111111111111111111111111111010

            ////시프트 연산자
            //int value = 4; //0100
            //Console.WriteLine(value << 1); // 8 (1000)
            //Console.WriteLine(value >> 1); // 2 (0010)

            ////삼항 연산자
            //int a = 10, b = 20;
            //int max = default;
            //max = (a > b) ? a : b;
            //Console.WriteLine(max);
            //// (비교) ? 참일때 값 : 거짓일때 값
            //int key =1;
            //string str = null;
            //str = (key == 2) ? "문이 열렸습니다." : "문을 못열었습니다.";
            //Console.WriteLine(str);

            // ?? , ??= 연산자 / is 연산자 , as 연산자
            //if , else if, else

            //Console.WriteLine("가지고있는 소지금을 입력하세요: ");
            //int money = int.Parse(Console.ReadLine());
            //int attack = 100;
            //int attackPlus = 0;
            //string weapon = null;
            //if (0<money && money <=100)
            //{
            //    Console.WriteLine("무한의 대검을 구매했습니다.");
            //    attackPlus = 1;
            //    weapon = "무한의 대검";
            //}
            //else if (101 <= money && money <= 200)
            //{
            //    Console.WriteLine("카타나를 구매했습니다.");
            //    attackPlus = 2;
            //    weapon = "카타나";
            //}
            //else if (201 <= money && money <= 300)
            //{
            //    Console.WriteLine("진은검을 구매했습니다.");
            //    attackPlus = 3;
            //    weapon = "진은검";
            //}
            //else if(301 <= money && money <= 400)
            //{
            //    Console.WriteLine("집판검을 구매했습니다.");
            //    attackPlus = 4;
            //    weapon = "집판검";
            //}
            //else if (401 <= money && money <= 500)
            //{
            //    Console.WriteLine("엑스칼리버을 구매했습니다.");
            //    attackPlus = 5;
            //    weapon = "엑스칼리버";
            //}
            //else if(501 <= money && money <= 600)
            //{
            //    Console.WriteLine("유령검을 구매했습니다.");
            //    attackPlus = 6;
            //    weapon = "유령검";
            //}
            //else if(601 <= money)
            //{
            //    Console.WriteLine("전설의 검을 구매했습니다.");
            //    attackPlus = 7;
            //    weapon = "전설의 검";
            //}
            //else
            //{
            //    Console.WriteLine("구매할 수 있는 무기가 없습니다.");
            //}

            //Console.WriteLine("캐릭터: 멋사검존");
            //Console.WriteLine("무기  : " + weapon);
            //Console.WriteLine("공격력: "+ attack + " + " + attackPlus);


            //switch 문

            //Console.Write("캐릭터를 선택하세요 (1.검사 2.마법사 3.도적): ");
            //int character = int.Parse(Console.ReadLine());
            //string characterName = null;
            //int attack = 0;
            //int defense = 0;

            //switch (character)
            //{
            //    case 1:
            //        Console.WriteLine("검사를 선택하셨습니다.");
            //        characterName = "검사";
            //        attack = 100;
            //        defense = 90;
            //        break;
            //    case 2:
            //        Console.WriteLine("마법사를 선택하셨습니다.");
            //        characterName = "마법사";
            //        attack = 110;
            //        defense = 80;
            //        break;
            //    case 3:
            //        Console.WriteLine("도적을 선택하셨습니다.");
            //        characterName = "도적";
            //        attack = 115;
            //        defense = 70;
            //        break;
            //    default:
            //        Console.WriteLine("잘못된 선택입니다.");
            //        break;
            //}

            //Console.WriteLine($"캐릭터: {characterName}");
            //Console.WriteLine($"공격력: {attack}");
            //Console.WriteLine($"방어력: {defense}");

            //alt + 드래그

            //반복문
            //0부터 9까지 출력하기 for문 활용하기
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //1부터 10까지의 합 구하기
            //int sum1to10 = 0;
            //for (int i = 1; i <= 10; i++)
            //{
            //    sum1to10 += i;
            //}
            //Console.WriteLine(sum1to10);
            //while문은 조건식 + 초기화 조건 직접 지정

            //랜덤
            //Random rand = new Random();
            //int randomInRange = 0;
            //for(int i=0; i < 100; i++)
            //{
            //    randomInRange = rand.Next(5, 15);
            //    Console.WriteLine(randomInRange);
            //}


            //for (int i = 0; i < 20; i++)
            //{
            //    int rnd = rand.Next(1, 101);
            //    if (rnd >= 1 && rnd <= 10)
            //    {
            //        Console.WriteLine("도끼등급 SSS");
            //    }
            //    else if (rnd >= 11 && rnd <= 30)
            //    {
            //        Console.WriteLine("도끼등급 SS");
            //    }
            //    else if (rnd >= 31 && rnd <= 60)
            //    {
            //        Console.WriteLine("도끼등급 S");
            //    }
            //    else if (rnd >= 61 && rnd <= 100)
            //    {
            //        Console.WriteLine("도끼등급 A");
            //    }
            //    else
            //    {
            //        Console.WriteLine("도끼등급 F");
            //    }
            //    Thread.Sleep(500);
            //}

            //do while문 do 실행 후 while 조건 체크
            //int x = 5;
            //do
            //{
            //    Console.WriteLine("do while문 실행");
            //    x--;
            //}while(x > 0);

            //foreach문 컬렉션(c#에서 사용되는 자료구조를 통칭해서 컬렉션이라 부름)
            //                                    (배열 또한 당연히 컬렉션 중 하나)
            //          의 모든 요소를 반복할 때 사용합니다.
            //                 
            //string[] fruits = { "사과", "바나나", "딸기", "포도", "수박" };
            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}

            //break문
            //반복문을 탈출할 수 있다.
            //for(int i = 0; i < 10; i++)
            //{
            //    if (i == 5)
            //    {
            //        break;
            //    }
            //    Console.WriteLine(i);
            //}

            //continue
            //현재 반복을 건너뛰고 다음 반복으로 넘어간다.
            //for(int i = 0; i <= 10; i++)
            //{
            //    if (i % 2 ==0 ) 
            //    {
            //        continue; //짝수는 건너뛴다.
            //    }
            //    Console.WriteLine(i);
            //}

            //goto 실행 흐름이 뒤죽박죽이 될 가능성이 높기 때문에 사용을 지양한다.
                   // goto 를 쓸바엔 객체지향 클래스를 적극적으로 활용하자

            //    int n = 1;
            //start:

            //    if(n<=5)
            //    {
            //        Console.WriteLine(n);
            //        n++;

            //        goto start;
            //    }



        }
    }
}
