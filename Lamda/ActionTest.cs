using System;
using static System.Console;

namespace ActionTest
{
    class MainApp
    {
        static void Main10(string[] args)
        {
            //Action 대리자의 경우 반환 형식이 없다는 것이 Func 대리자와의 차이점이다.
            Action act1 = () => WriteLine("Action()");
            act1();

            int res = 0;
            Action<int> act2 = (x) => res = x * x;

            act2(3);
            WriteLine($"result : {res}");

            Action<double, double> act3 = (x, y) =>
            {
                double pi = x / y;
                WriteLine($"Action<T1, T2>({x}, {y}) : {pi}");
            };

            act3(22.0, 7.0);
        }
    }
}
