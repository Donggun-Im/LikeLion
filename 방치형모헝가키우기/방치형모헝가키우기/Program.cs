using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 모험가키우기
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Random rand = new Random();
            int gold = 0;
            
            int input = 0;
            int health = 100;
            int power = 10;

           

            

            while (true)
            {
                Console.Clear();
                Console.WriteLine("현재 상태: 체력 {0} | 공격력 {1} | 골드 {2}", health, power, gold);
                Console.WriteLine($"1: ⚔️탐험⚔️");
                Console.WriteLine($"2: 🎲장비 구매🎲");
                Console.WriteLine($"3: 🏕️휴식🏕️");
                Console.WriteLine("4: 종료");
                Console.Write("선택: ");
                input = int.Parse(Console.ReadLine());
                if (health <= 0)
                {
                    Console.WriteLine("💀체력이 0이 되어 게임이 종료되었습니다💀");
                    break;
                }
                if (input == 1)
                {
                    Console.Clear();
                    Console.WriteLine("탐험을 시작합니다.");
                    Thread.Sleep(500);
                    Console.WriteLine("탐험을 시작합니다..");
                    Thread.Sleep(500);
                    Console.WriteLine("탐험을 시작합니다...");
                    Thread.Sleep(500);
                    Console.WriteLine("탐험을 시작합니다....");

                    int eventchance = rand.Next(1, 101);

                    if (eventchance <= 30)
                    {
                        int damage = rand.Next(5, 21);
                        health -= damage;
                        Console.WriteLine("⚔️몬스터를 만났습니다⚔️ (체력 - {0}", damage,);
                        
                    }
                    else if (eventchance <= 70)
                    {
                        int reward = rand.Next(100, 301);
                        gold += reward;
                        Console.WriteLine("💰보물을 발견했습니다💰 (획득 골드: {0})", reward);
                    }
                    else
                    {
                        int heal = rand.Next(10, 31);
                        Console.WriteLine("🌿포션을 발견했습니다🌿 (체력 + {0})", heal);
                        health += heal;
                        if(health > 100)
                        {
                            health = 100;
                        }
                    }
                    Thread.Sleep(2000);
                }
                else if (input == 2)
                {
                    if (gold <= 1000)
                    {
                        gold -= 1000;
                        Console.Clear();
                        Console.WriteLine("🎲장비를 구매하였습니다🎲");

                        int rnd = rand.Next(1, 101);

                        if (rnd == 1)
                        {
                            Console.WriteLine("SSS급 전설의 검 (공격력 +50) 획득!");
                            power += 50;
                        }
                        else if (rnd <= 10)
                        {
                            Console.WriteLine("SS급 희귀한 검 (공격력 +30) 획득!");
                            power += 30;
                        }
                        else if (rnd <= 30)
                        {
                            Console.WriteLine("S급 강철 검 (공격력 +20) 획득!");
                            power += 20;
                        }
                        else
                        {
                            Console.WriteLine("녹슨 칼 (공격력 +5) 획득!");
                            power += 5;
                        }
                        Thread.Sleep(1000);

                    }
                    else
                    {
                        Console.WriteLine("💰골드가 부족합니다💰 (1000골드 필요)");
                        Thread.Sleep(1000);
                    }
                }
                else if (input == 3)
                {
                    Console.WriteLine("휴식을 취합니다.");
                    health += 20;
                    Thread.Sleep(1000);
                }
                else if(input == 4)
                {
                    Console.WriteLine("게임을 종료합니다.");
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 선택하세요.");
                    Thread.Sleep(1000);
                }
            }
            Console.WriteLine("게임을 종료합니다!");
        }
    }

}
