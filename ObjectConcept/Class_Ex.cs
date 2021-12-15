using System;
using static System.Console;

namespace BasicClass
{
    class Cat //고양이를 추상화한다
    {
        public string name;
        public string color;
        public Cat()
        {
            name = "";
            color = "";
        }
        public Cat(string _name, string _color)
        {
            name = _name;
            color = _color;
        }

        //주로 하드웨어를 종료시켜야 할 때는 잘 작동하지만
        //일반적인 소프트웨어에서는 확인하기 어려움
        ~Cat()
        {
            WriteLine($"{name} : 잘가~");
        }

        public void meow()
        {
            WriteLine($"{name} : 야옹");
        }
    }

    class MainApp
    {
        static void Main1(string[] args)
        {
            Cat lulu = new Cat(); //lulu 라는 고양이 객체를 생성
            lulu.color = "brown";
            lulu.name = "LuLu";
            lulu.meow();
            WriteLine($"{lulu.name} : {lulu.color}");

            Cat dd = new Cat(); //dd 라는 고양이 객체를 생성
            dd.color = "white-brown";
            dd.name = "DD";
            dd.meow();
            WriteLine($"{dd.name} : {dd.color}");

            Cat lala = new Cat("lala", "shinny white");
            lala.meow();
            WriteLine($"{lala.name} : {lala.color}");

            WriteLine();
            ReadLine();
        }
    }
}