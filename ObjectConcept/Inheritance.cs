using System;
using static System.Console;

namespace Inheritance
{
    //sealed class Base -> sealed 한정자를 이용해 상속이 불가능하도록 클래스를 선언할 수 있음
    class Base
    {
        protected string Name;
        public Base(string name)
        {
            this.Name = name;
            WriteLine($"{this.Name}.Base()");
        }

        ~Base()
        {
            WriteLine($"{this.Name}.~Base()");
        }

        public void BaseMethod()
        {
             WriteLine($"{Name}.BaseMethod()");
        }
    }

    class Derived : Base
    {
        public Derived(string Name) : base(Name)
        {
            WriteLine($"{this.Name}.Derived()");
        }
        ~Derived()
        {
            WriteLine($"{this.Name}.~Derived()");
        }

        public void DerivedMethod()
        {
            WriteLine($"{Name}.DerivedMethod()");
        }
    }

    class MainApp
    {
        static void Main6(string[] args)
        {
            Base a = new Base("a");
            a.BaseMethod();

            Derived b = new Derived("b");
            b.BaseMethod();
            b.DerivedMethod();
        }
    }
}
