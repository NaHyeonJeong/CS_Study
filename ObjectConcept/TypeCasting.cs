using System;
using static System.Console;

namespace TypeCasting
{
    class Mammal
    {
        public void Nurse()
        {
            WriteLine("Nurse()");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            WriteLine("Bark()");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            WriteLine("Meow()");
        }
    }

    class MainApp
    {
        static void Main7(string[] args)
        {
            Mammal mammal = new Dog();
            Dog dog;

            if(mammal is Dog)
            {
                dog = (Dog)mammal;
                dog.Bark();
            }

            Mammal mammal2 = new Cat();

            Cat cat = mammal2 as Cat;
            if(cat != null) //mammal2가 Cat 형식 변환에 실패했다면 cat은 null이 된다
            {
                cat.Meow();
            }

            Cat cat2 = mammal as Cat;
            if (cat2 != null)
                cat2.Meow();
            else
                WriteLine("cat2 is not a Cat");
        }
    }
}
