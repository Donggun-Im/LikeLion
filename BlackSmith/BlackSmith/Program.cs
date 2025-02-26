using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace BlackSmith
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();
            char input = 'A';
            int wood = 0;
            int randNum = 0;
            int IAxeGrade = 1;
            string strAxeGrade = "D";
            string temp = "A";
            Thread.Sleep(1000);
            Console.WriteLine("             ■■■■■■■■■■■■■■■");
            Thread.Sleep(100);
            Console.WriteLine("             ■                          ■");
            Thread.Sleep(100);
            Console.WriteLine("             ■                          ■");
            Thread.Sleep(100);
            Console.WriteLine("             ■       대장장이키우기     ■");
            Thread.Sleep(100);
            Console.WriteLine("             ■                          ■");
            Thread.Sleep(100);
            Console.WriteLine("             ■                          ■");
            Thread.Sleep(100);
            Console.WriteLine("             ■■■■■■■■■■■■■■■");

            Console.Write("나무 캐기(Q)     도끼 만들기(W)       게임 종료(E): ");
            while (input != 'E')
            {
                temp = Console.ReadLine();
                if (temp == "")
                { continue; }
                else
                {
                    input = temp.ToUpper()[0];
                }
            
                Console.Clear();
                if (input == 'Q')
                {
                    wood += IAxeGrade;
                }
                else if (wood >= 10 && input == 'W')
                {

                    randNum = rnd.Next(1, 100);

                    if (randNum <= 3)
                    {
                        Console.WriteLine("SSS급 도끼를 만들었습니다");
                        IAxeGrade = 20;
                        strAxeGrade = "SSS";
                        wood -= 10;

                    }
                    else if (randNum <= 10 && IAxeGrade < 8)
                    {
                        Console.WriteLine("SS급 도끼를 만들었습니다");
                        IAxeGrade = 8;
                        strAxeGrade = "SS";
                        wood -= 10;
                    }
                    else if (randNum <= 30 && IAxeGrade < 4)
                    {
                        Console.WriteLine("S급 도끼를 만들었습니다");
                        IAxeGrade = 4;
                        strAxeGrade = "S";
                        wood -= 10;
                    }
                    else if (IAxeGrade < 2)
                    {
                        Console.WriteLine("A급 도끼를 만들었습니다");
                        IAxeGrade = 2;
                        strAxeGrade = "A";
                        wood -= 10;
                    }
                    else
                    {
                        if (IAxeGrade == 20)
                        {
                            Console.WriteLine("도끼는 최고 등급입니다");
                        }
                        else
                        {
                            Console.WriteLine("꽝");
                            wood -= 10;
                        }
                    }

                }
                else
                {
                    Console.WriteLine("나무를 캐야합니다");
                }
                Console.WriteLine("나무: {0}", wood);
                Console.WriteLine("도끼 등급: {0}", strAxeGrade);
            }

            Environment.Exit(0);

        }
    }

    //ctrl + k + d 줄 정렬 , ctrl + k +f 띄워쓰기 정리
}
