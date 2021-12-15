using System;
using static System.Console;

namespace DeepCopy
{
    class MyClass : ICloneable
    {
        //field
        public int MyField1;
        public int MyField2;

        //method
        //객체를 생성할 때 마다 힙에 새로 할당해서 그곳에 자신의 멤버를 일일이 복사해 넣음
        public Object Clone()
        {
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }

    class MainApp
    {
        static void Main3(string[] args)
        {
            WriteLine("Shallow Copy");
            //같은 힙 공간을 가리키고 있음
            {
                MyClass source = new MyClass(); 
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                WriteLine($"{source.MyField1} {source.MyField2}");
                WriteLine($"{target.MyField1} {target.MyField2}");
            }

            WriteLine("Deep Copy");
            //다른 힙 공간을 가리키고 있음
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = (MyClass)source.Clone();
                target.MyField2 = 30;

                WriteLine($"{source.MyField1} {source.MyField2}");
                WriteLine($"{target.MyField1} {target.MyField2}");
            }
        }
    }
}
