using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("2진수를 입력하세요:");
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2);
            //string binaryOutput = Convert.ToString(decimalValue, 2);
            //Console.WriteLine($"입력한 이진수: {binaryInput}");
            //Console.WriteLine($"변환된 10진수: {decimalValue}");
            //Console.WriteLine($"변환된 이진수: {binaryOutput}");

            //var를 사용하여 변수 선언
            //var name = "Alice";
            //var age = 30;
            //var isStudent = true;
            //Console.WriteLine($"이름: {name}, 나이: {age}, 학생 여부: {isStudent}");

            //default 키워드 사용한 기본값 설정
            //int defaultInt = default;
            //string defaultString = default;
            //bool defaultBool = default;
            //Console.WriteLine($"int 기본값: {defaultInt}");
            //Console.WriteLine($"string 기본값: {defaultString}");
            //Console.WriteLine($"bool 기본값: {defaultBool}");

            //산술 연산자
            //int a = 5, b = 3;
            //int sum = 0;
            //sum = a + b;
            //Console.WriteLine($"합: {sum}");
            //sum = a - b;
            //Console.WriteLine($"차: {sum}");
            //sum = a * b;
            //Console.WriteLine($"곱: {sum}");
            //sum = a / b;
            //Console.WriteLine($"나누기: {sum}");
            //sum = a % b;
            //Console.WriteLine($"나머지: {sum}");

            //bool isEquals = false;
            //int a = 5, b = 5;
            ////관계형 연산자
            //isEquals = a == b;
            //Console.WriteLine($"a와 b가 같은가? {isEquals}");

            // 단항 연산자 +, , !, ~

            //캐스팅
            //double pi = 3.141592;
            //int integerPi = (int)pi;
            //Console.WriteLine(integerPi);
            //나누기 할때 int가 들어가면 소수점 아래가 사라져서 캐스팅 하는 경우가 많음

            //문자열 연결
            //string firstName = "Alice";
            //string lastName = "Smith";
            //string fullName = firstName + " " + lastName;
            //Console.WriteLine(fullName);

            //할당 연산자 , 증감연산자
            //int a = 10;
            //a += 5;
            //Console.WriteLine(a);
            //a -= 5;
            //Console.WriteLine(a);
            //a *= 5;
            //Console.WriteLine(a);
            //a /= 5;
            //Console.WriteLine(a);
            //a %= 5;
            //Console.WriteLine(a);
            //Console.WriteLine("a++: "+a++);
            //Console.WriteLine("a: "+a);
            //Console.WriteLine("++a: "+ ++a);

            //문제1. 학점 평균 계산 프로그램
            //Console.Write("국어 점수를 입력하세요: ");
            //int korScore =int.Parse(Console.ReadLine());
            //Console.Write("영어 점수를 입력하세요: ");
            //int engScore = int.Parse(Console.ReadLine());
            //Console.Write("수학 점수를 입력하세요: ");
            //int mathScore = int.Parse(Console.ReadLine());
            //double avgScore = ((double)korScore + (double)engScore + (double)mathScore) / 3.0;
            //Console.WriteLine($"평균 점수: "+avgScore.ToString("F2"));

            ////문제2. 비트 반전(~) 연산자 활용 프로그램
            //Console.Write("정수를 입력하세요: ");
            //int input = int.Parse(Console.ReadLine());
            //int output = ~input;
            //Console.WriteLine($"입력한 정수: {input}");
            //Console.WriteLine($"비트 반전한 정수: {output}");

            //관계형 연산자
            //int x = 5, y = 10;
            //Console.WriteLine(x == y);  //false
            //Console.WriteLine(x != y);  //ture
            //Console.WriteLine(x > y);   //false
            //Console.WriteLine(x < y);   //true
            //Console.WriteLine(x >= y);  //false
            //Console.WriteLine(x <= y);  //true

            ////논리 연산자
            //bool a = true, b = false;
            //Console.WriteLine(a && b);  //false
            ////AND   :   1:1   t
            ////      :   1:0   f
            ////      :   0:1   f
            ////      :   0:0   f
            //Console.WriteLine(a || b);  //true
            ////OR    :   1:1   t
            ////      :   1:0   t
            ////      :   0:1   t
            ////      :   0:0   f
            //Console.WriteLine(!a);       //false
            ////NOT   :   1      f
            ////      :   0      t
            ///
        }
    }
}
