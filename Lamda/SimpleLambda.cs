using System;
using static System.Console;

namespace SimpleLambda
{
    class MainApp
    {
        delegate int Calculate(int a, int b); //무명 메소드(람다식)를 사용하기 위해서는 대리자를 선언해야 한다

        static void Main1(string[] args)
        {
            Calculate calc = (a, b) => a + b;
            WriteLine($"4 + 5 = {calc(4, 5)}");
            WriteLine($"{4} + {5} = {calc(4, 5)}");
        }
    }
}