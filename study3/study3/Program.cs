using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study3
{
    class Program
    {
        static void Main(string[] args)
        {
            string character = "캐릭터";
            int Hp = 100;
            float Att = 56.7f;
            string CharacterName = "??";
            char Grade = 'S';

            Console.WriteLine(character);
            Console.WriteLine("hp : " + Hp);
            Console.WriteLine("att : " + Att);
            Console.WriteLine("캐릭터이름 : " + CharacterName);
            Console.WriteLine("등급 : " + Grade);
        }
    }
}
