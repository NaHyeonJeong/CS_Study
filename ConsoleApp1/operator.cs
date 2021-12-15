using System;
using System.Collections;
using static System.Console;

namespace Operator
{
    public class Program2
    {
        static void Main2(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구"); //a?.가 null(false)을 반환하기 때문에 Add()메소드는 호출되지 않음
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            a = new ArrayList();
            a?.Add("야구"); //a는 이제 null이 아니기 때문에 Add()를 사용할 수 있음
            a?.Add("축구");
            a?.Add("배구");
            WriteLine($"Count : {a?.Count}");
            for(int i = 0; i < a.Count; i++)
            {
                WriteLine($"{a?[i]}");
            }
            /*WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");
            WriteLine($"{a?[2]}");*/
        }
    }
}