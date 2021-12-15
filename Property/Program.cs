using System;
using static System.Console;

namespace Property
{
    class BirthdayInfo
    {
        private string name;
        private DateTime birth;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public DateTime Birthday
        {
            get { return birth; }
            set { birth = value; }
        }

        public int Age
        {
            get{return new DateTime(DateTime.Now.Subtract(birth).Ticks).Year;}
        }
    }

    class MainApp
    {
        static void Main10(string[] args)
        {
            BirthdayInfo birth = new BirthdayInfo()
            { //객체를 생성할 때 각 필드를 초기화 하는 방법
                Name = "나현정",
                Birthday = new DateTime(1999, 7, 12)
            };
            /*birth.Name = "나현정";
            birth.Birthday = new DateTime(1999, 7, 12);*/

            WriteLine($"Name : {birth.Name}");
            WriteLine($"Birthday : {birth.Birthday.ToShortDateString()}");
            WriteLine($"Age : {birth.Age}");
        }
    }
}