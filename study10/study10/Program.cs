using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace study10
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] num = new int[3];  //3개 메모리 만들겠다.

            //num[0] = 10;
            //num[1] = 20;
            //num[2] = 30;


            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(num[i]);
            //}

            //int[] numbers = { 1, 2, 0};  //간단한 선언과 초기화
            //int[] numbers2 = new int[3]; //크기만 지정
            //int[] numbers3 = new int[] { 1, 2, 0 }; //초기화와 함께 선언
            //for(int i =0; i<3; i++)
            //{
            //    Console.WriteLine(numbers3[i]);
            //}
            //string[] fruits = { "사과", "바나나", "포도", "딸기" };
            //for (int i=0; i<4;i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //    Console.WriteLine(fruits[i][0]);
            //}

            //3명의
            //국어, 영어, 수학 점수를 입력받고
            //총점과 평균을 출력하세요
            //int[,] Scores = new int[3, 3];
            //int[] Total = new int[3];
            //double[] Avg = new double[3];
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine("{0}번째 학생의 국어, 영어, 수학 점수를 입력하세요", i + 1);
            //    for (int j = 0; j < 3; j++)
            //    {
            //        Console.Write("{0}번째 학생의 {1}번째 과목 점수를 입력하세요: ", i + 1, j + 1);
            //        Scores[i, j] = int.Parse(Console.ReadLine());
            //    }
            //    Total[i] = Scores[i, 0] + Scores[i, 1] + Scores[i, 2];
            //    Avg[i] = (double)Total[i] / 3.0;
            //    //Avg[i] = Math.Round((double)Total[i] / 3.0,2);
            //}
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(String.Format("{0}번째 학생의 총점은 {1}이고 평균은 {2:F2}입니다.", i, Total[i], Avg[i]));
            //}

            ////숫자 ,로 끊기
            //double value = 123124124.12323;
            //Console.WriteLine(value.ToString("N2"));

            ////배열.Length
            //int[] scores = new int[3];

            //scores[0] = 90;
            //scores[1] = 85;
            //scores[2] = 88;



            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"점수 {i + 1}:{scores[i]}");
            //}

            //6.가변 배열(Jagged Array)
            //가변 배열 선언
            //int[][] matrix = new int[3][];
            //matrix[0] = new int[3];
            //matrix[1] = new int[4];
            ////초기화
            //matrix[0][0] = 1;
            //matrix[0][1] = 2;
            //matrix[0][2] = 3;
            //matrix[1][0] = 4;
            //matrix[1][1] = 5;
            //matrix[1][2] = 6;
            //matrix[1][3] = 7;
            ////출력
            //for (int i = 0; i < matrix.Length; i++)
            //{
            //    for (int j = 0; j < matrix[i].Length; j++)
            //    {
            //        Console.Write(matrix[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            ////7. var 키워드로 배열 선언하기
            //Console.WriteLine("var 키워드 사용");
            //var numbers = new[] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(numbers.GetType());

            int[] iArray = new int[25];
            Random rand = new Random();
            int iBingo = 0;
            int input = 0;
            int iCount = 0;

            for (int i = 0; i < 25; i++)
            {
                iArray[i] = i + 1;
            }

            for (int i = 0; i < 100; i++)
            {
                int iA = rand.Next(0, 25);
                int iB = rand.Next(0, 25);
                int temp = 0;
                temp = iArray[iA];
                iArray[iA] = iArray[iB];
                iArray[iB] = temp;

            }
            while (true)
            {
                input = 0;
                iCount = 0;

                Console.Clear();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (iArray[i * 5 + j] == 0)
                        {
                            Console.Write(" * ");
                        }
                        else
                        {
                            Console.Write((iArray[i * 5 + j]).ToString("D2") + " ");
                        }

                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("빙고 갯수: " + iBingo);
                iBingo = 0;
                Console.WriteLine("숫자를 입력하세요");
                input = int.Parse(Console.ReadLine());
                for (int i = 0; i < 25; i++)
                {
                    if (iArray[i] == input)
                    {
                        iArray[i] = 0;
                        break;
                    }
                }
                //빙고 체크 로직
                //가로 체크
                for (int i = 0; i < 5; i++)
                {

                    for (int j = 0; j < 5; j++)
                    {
                        //copilot 코드인데 이게 더 좋아보임
                        //if (iArray[i * 5 + j] != 0)
                        //{
                        //    break;
                        //}
                        //if (j == 4)
                        //{
                        //    iBingo++;
                        //}

                        //강의 코드
                        if (iArray[i * 5 + j] == 0)
                        {
                            ++iCount;
                        }
                        if (iCount == 5)
                        {
                            ++iBingo;
                        }

                    }
                    iCount = 0;
                }
                //세로 체크
                for (int i = 0; i < 5; i++)
                {
                    
                    for (int j = 0; j < 5; j++)
                    {
                        //copilot 코드인데 이게 더 좋아보임
                        //if (iArray[i * 5 + j] != 0)
                        //{
                        //    break;
                        //}
                        //if (j == 4)
                        //{
                        //    iBingo++;
                        //}

                        //강의 코드
                        if (iArray[i + 5 * j] == 0)
                        {
                            ++iCount;
                        }
                        if (iCount == 5)
                        {
                            ++iBingo;
                        }
                    }
                    iCount = 0;
                }
                //대각선 오른쪽 체크
                for (int i = 0; i < 5; ++i)
                {
                    if (iArray[i * 4+4] == 0)
                    {
                        ++iCount;
                    }
                    if (iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;
                //대각선 왼쪽 체크
                for (int i = 0; i < 5; ++i)
                {
                    if (iArray[i * 6] == 0)
                    {
                        ++iCount;
                    }
                    if (iCount == 5)
                    {
                        ++iBingo;
                    }
                }
                iCount = 0;

            }
        }
    }
}

