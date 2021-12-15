/*
작성일 : 2021년 12월 01일 수요일
작성자 : 나현정
 */
using System; //System library 사용 - 단축해서 클래스 등을 사용할 수 있음
using static System.Console;

namespace Hello
{
    public class Program
    {
        static void Main1(string[] args) //entry point
        {
            Console.WriteLine("Hello, World!");
            object a = null;
            int b = 0;
            Console.WriteLine(b.GetType()); //변수의 type을 알 수 있음

            string s = string.Format("{0, -10}DEF", "ABC");
            Console.WriteLine(s);
            s = string.Format("{0, 10}DEF", "ABC");
            Console.WriteLine(s);

            DateTime dt = new DateTime(2021, 12, 1);
            Console.WriteLine("{0}", dt);

            string s2;
            var greeting = "Good Morning"; //약한 형식 검사 - 컴파일러가 형식 추론 - 반드시 초기화 필요함
            Console.WriteLine(greeting.Substring(0, 5));
            WriteLine(greeting.Length);

            WriteLine("Hello {0}", greeting);


        }
    }
}

