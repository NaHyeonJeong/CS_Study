/**
 * 확장 메소드
 */
using System;
using static System.Console;
using MyExtension;

namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }
        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; i++)
            {
                result *= myInt;
            }
            return result;
        }
    }
    
}

namespace ExtensionMethod
{
    class MainApp
    {
        static void Main10(string[] args)
        {
            WriteLine($"3^2 : {3.Power(2)}");
            WriteLine($"3^4 : {3.Power(4)}");
            WriteLine($"2^10 : {2.Power(10)}");
        }
    }
}
