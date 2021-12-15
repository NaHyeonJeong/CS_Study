using System;
using static System.Console;

namespace BranchState
{
    public class Program3
    {
        static void Main3(string[] args)
        {
            /*int[] arr = new int[] { 0, 1, 2, 3, 4 };
            foreach (int a in arr)
                Console.WriteLine(a);*/

            ///////////// switch 식 ///////
            WriteLine("점수를 입력하세요");
            int score = Convert.ToInt32(Console.ReadLine());

            WriteLine("재수강인가요?(y/n)");
            string line = Console.ReadLine(); //입력 받기 위해서는 ReadLine()
            bool repeated = line == "y" ? true : false; //조건 연산자의 값을 line에 넣고 line의 값을 bool 타입 변수에 넣음

            string grade = (int)(Math.Truncate(score / 10.0) * 10) switch
            {
                90 when repeated == true => "B+", //분기 처리
                90 => "A",
                80 => "B",
                70 => "C",
                60 => "D",
                _ => "F"
            };

            WriteLine($"학점 : {grade}");
        }
    }
}