using System;
using static System.Console;

namespace FuncTest
{
    class MainApp
    {
        static void Main3(string[] args)
        {
            //Func 대리자의 매개변수 중 맨 마지막 매개변수가 반환 형식
            Func<int> func1 = () => 10;
            WriteLine($"func1() : {func1()}");

            Func<int, int> func2 = (x) => x * 2;
            WriteLine($"func2(4) : {func2(4)}");

            Func<double, double, double> func3 = (x, y) => x / y;
            WriteLine($"func3(22, 7) : {func3(22, 7)}");
        }
    }
}
