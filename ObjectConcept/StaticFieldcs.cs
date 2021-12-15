using System;
using static System.Console;

namespace ObjectConcept
{
    class Global
    {
        public static int count = 0;
    }

    class ClassA
    {
        public ClassA()
        {
            Global.count++;
        }
    }

    class ClassB
    {
        public ClassB()
        {
            Global.count++;
        }
    }

    class MainApp
    {
        static void Main2()
        {
            WriteLine($"Global Count = {Global.count}");

            new ClassA(); //static을 사용했기 때문에 객체 생성 없이도 호출이 가능해진다
            new ClassA();
            new ClassB();
            new ClassB();

            WriteLine($"Global Count = {Global.count}");
        }
    }
}
