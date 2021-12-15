using System;
using static System.Console;

namespace Example
{
    public class Program4
    {
        static void Main4(string[] args)
        {
            while (true)
            {
                Write("반복 횟수를 입력하세요 : ");
                int cnt = Convert.ToInt32(Console.ReadLine());

                if (cnt <= 0)
                {
                    Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다");
                    continue;
                }
                else
                {
                    for (int i = 0; i <= cnt; i++)
                    {
                        for (int j = 0; j <= i; j++)
                        {
                            Write("*");
                        }
                        WriteLine();
                    }
                }
            }
        }
    }
}