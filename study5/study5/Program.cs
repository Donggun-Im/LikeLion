﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study5
{
    class Program
    {
        static void Main(string[] args)
        {
            ////숫자 데이터 형식: 정수와 실수를 다룰 때 사용하는 다양한 타입
            //int integerNum = 10;
            //float floatNum = 3.14f;  //단정밀도 실수
            //double doubleNum = 3.14159; //배정밀도 실수
            //Console.WriteLine(integerNum);
            //Console.WriteLine(floatNum);
            //Console.WriteLine(doubleNum);

            //정수 데이터형식: 소수점이 없는 숫자를 표현
            //int intValue = -100; //4바이트 크기의 정수
            //long longValue = 1234567890l;
            //Console.WriteLine(intValue);
            //Console.WriteLine(longValue);

            //부호 있는 정수 : 음수와 양수를 모두 표현 가능
            //sbyte signedByte = -50;     //1바이트 크기
            //short signedShort = -32000; //2바이트 크기
            //int signedInt = -2000000000;//4바이트 크기
            //Console.WriteLine(signedByte);
            //Console.WriteLine(signedShort);
            //Console.WriteLine(signedInt);

            //부호없는 정수 데이터 형식
            //byte unsignedByte = 255; //1바이트 크기
            //ushort unsignedShort = 65535; //2바이트 크기
            //uint unsignedInt = 4000000000; //4바이트 크기
            //Console.WriteLine(unsignedByte);
            //Console.WriteLine(unsignedShort);
            //Console.WriteLine(unsignedInt);

            //실수형 데이터 형식: 소수점을 포함한 숫자를 표현
            //float singlePrecision = 3.141592f; //4바이트 크기
            //double doublePrecision = 3.14159265358979; //8바이트 크기
            //decimal decimalPrecision = 3.141592653589793238m; //16바이트 크기
            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(decimalPrecision);

            //숫자 형식의 리터럴 값에 접미사 붙이기
            //int integerValue = 100; //기본 정수형 (int)
            //long longValue = 1234567890L; //long형 리터럴
            //float floatValue = 3.14f; //float형 리터럴
            //double doubleValue = 3.14159; //double형 리터럴
            //decimal decimalValue = 3.14159265358979323846m; //decimal형 리터럴
            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);

            //char letter = 'A'; //문자 'A' 저장
            //char symbol = '#'; //특수 기호 저장
            //char number = '9'; //숫자 형태의 문자 저장
            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);

            //string 형식: 여러 문자를 저장
            //string greeting = "Hello World!"; //문자열 저장
            //string name = "Alice"; //이름 저장
            //Console.WriteLine(greeting);
            //Console.WriteLine(name);
            //Console.WriteLine(greeting+" "+name);

            //bool형식 : 참(true) =1, 거짓(false) = 0
            //bool isRunning = true; //프로그램 실행 상태
            //bool isFinished = false; //프로그램 종료 상태 X
            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);

            // const: 변하지 않는 값을 정의
            //double Pi = 3.141459; //원주율
            //const int MaxScore = 100; //최대 점수
            //Console.WriteLine(Pi);
            //Console.WriteLine(MaxScore); cons
            ////Pi = 3.14; //오류 발생 상수 값은 변경할 수 업습니다.

            //닷넷 형식 : 기본 형식의 닷넷표현
            //System.Int32 number = 123; //inte닷넷형식
            //Int32 number2 = 123; //int 닷넷형식 (using System)
            //System.String text = "Hello"; //string의 닷넷형식
            //System.Boolean flag = true; //bool의 닷넷형식
            //Console.WriteLine(number);
            //Console.WriteLine(number2);
            //Console.WriteLine(text);
            //Console.WriteLine(flag);

            ////int 래퍼 형식의 메서드 활용
            //int number = 123;
            //string numberAsString = number.ToString(); //정수를 문자열로 변환
            ////bool 래퍼 형식의 메서드 활용
            //bool flag = true;
            //string flagAsString = flag.ToString(); //논리값을 문자열로 변환
            //Console.WriteLine(numberAsString);
            //Console.WriteLine(flagAsString);



        }

    }
}
