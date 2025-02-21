using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studyReadLinge
{
    class Program
    {
        static void Main(string[] args)
        {
            ////사용자 입력을 문자열로 받기
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine();
            //Console.WriteLine($"안녕하세요, {userName}님!");

            ////문자열을 정수로 변환
            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine(); //사용자로부터 입력(string) 받기
            //int age = int.Parse(input); //string을 int로 변환
            //Console.WriteLine($"1년 후면 {age + 1}살이 되겠군요!"); //변환된 값 사용
            //Console.WriteLine("내년에는 " + (age + 1) + "살이 되겠군요!");
            //Console.WriteLine("내년에는 {0}살이 되겠군요!", age + 1);
            ////문자열 +정수
            ///
            Console.Write("루인 스킬 피해: ");
            float ruinSkillDamage = float.Parse(Console.ReadLine());
            Console.Write("카드 게이지 획득량: ");
            float cardGaugeGain = float.Parse(Console.ReadLine());
            Console.Write("각성기 피해: ");
            float ultDamage = float.Parse(Console.ReadLine());
            Console.Write("최대 마나: ");
            int maxMana = int.Parse(Console.ReadLine());
            Console.Write("전투 중 마나 회복량: ");
            int onBattleManaRege = int.Parse(Console.ReadLine());
            Console.Write("비전투 중 마나 회복량: ");
            int offBattleManaRege = int.Parse(Console.ReadLine());
            Console.Write("이동 속도: ");
            float movingSpeed = float.Parse(Console.ReadLine());
            Console.Write("탈 것 속도: ");
            float ridingSpeed = float.Parse(Console.ReadLine());
            Console.Write("운반 속도: ");
            float carrySpeed = float.Parse(Console.ReadLine());
            Console.Write("스킬 재사용 대기시간 감소: ");
            float skillCoolDown = float.Parse(Console.ReadLine());
            Console.WriteLine();


            Console.WriteLine("활동");
            Console.Write("루인 스킬 피해            ");
            Console.WriteLine("{0}%", ruinSkillDamage);
            Console.Write("카드 게이지 획득량        ");
            Console.WriteLine("{0}%", cardGaugeGain);
            Console.Write("각성기 피해               ");
            Console.WriteLine("{0}%", ultDamage);
            Console.Write("최대 마나                 ");
            Console.WriteLine("{0}", maxMana);
            Console.Write("전투 중 마나 회복량       ");
            Console.WriteLine("{0}", onBattleManaRege);
            Console.Write("비전투 중 마나 회복량     ");
            Console.WriteLine("{0}", offBattleManaRege);
            Console.Write("이동 속도                 ");
            Console.WriteLine("{0}%", movingSpeed);
            Console.Write("탈 것 속도                ");
            Console.WriteLine("{0}%", ridingSpeed);
            Console.Write("운반 속도                 ");
            Console.WriteLine("{0}%", carrySpeed);
            Console.Write("스킬 재사용 대기시간 감소 ");
            Console.WriteLine("{0}%", skillCoolDown);

        }
    }
}
