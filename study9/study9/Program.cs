using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        }
    }
}
