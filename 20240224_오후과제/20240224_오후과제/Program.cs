using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20240224_오후과제
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("문제 1. 세 정수의 최대값 구하기");
            int a, b, c;
            int max;
            Console.WriteLine("정수 3개를 입력하세요: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                max = a;
            }
            else if (b > c)
            {
                max = b;
            }
            else
            {
                max = c;
            }

            Console.WriteLine("최대값:{0}", max);

            Console.WriteLine("문제 2. 점수에 따른 학점 평가");
            int score;
            score = Convert.ToInt32(Console.ReadLine());
            if (score >= 90)
            {
                Console.WriteLine("A");
            }
            else if (score >= 80)
            {
                Console.WriteLine("B");
            }
            else if (score >= 70)
            {
                Console.WriteLine("C");
            }
            else if (score >= 60)
            {
                Console.WriteLine("D");
            }
            else
            {
                Console.WriteLine("F");
            }

            Console.WriteLine("문제 3. 간단한 사칙연산 계산기");
            Console.WriteLine("숫자 두개와 연산자를 입력하세요(+,-,*,/): ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            char op = Convert.ToChar(Console.ReadLine());

            if (op == '+')
            {
                Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            }
            else if (op == '-')
            {
                Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            }
            else if (op == '*')
            {
                Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            }
            else if (op == '/')
            {
                Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            }
            else
            {
                Console.WriteLine("잘못된 연산자입니다.");
            }
        }
    }
}
