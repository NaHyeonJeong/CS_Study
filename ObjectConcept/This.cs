using System;
using static System.Console;

namespace ThisConstructor
{
    class MyClass
    {
        int a, b, c;

        public MyClass() 
            //a를 초기화
        {
            this.a = 5242;
            WriteLine("MyClass()");
        }

        public MyClass(int b) : this()
            //a초기화는 MyClass()에서 했기 때문에
            //여기서는 b를 초기화
        {
            this.b = b;
            WriteLine($"MyClass({b})");
        }

        public MyClass(int b, int c) : this(b)
            //a의 초기화는 MyClass(), b의 초기화는 MyClass(b)에서 했기 때문에
            //여기서는 c를 초기화
        {
            this.c = c;
            WriteLine($"MyClass({b}, {c})");
        }

        public void PringFields()
        {
            WriteLine($"a : {a}, b : {b}, c : {c}");
        }
    }

    class MainApp
    {
        static void Main4(string[] args)
        {
            MyClass a = new MyClass();
            a.PringFields();
            WriteLine();

            MyClass b = new MyClass(1);
            b.PringFields();
            WriteLine();

            MyClass c = new MyClass(10, 20);
            c.PringFields();
        }
    }
}
