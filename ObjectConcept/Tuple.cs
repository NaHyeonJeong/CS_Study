/**
 * 튜플
 */
using System;
using static System.Console;

namespace PosisionalPattern
{
    class MainApp
    {

        private static double GetDiscountRate(object client)
        {
            return client switch
            {
                ("학생", int n) when n < 18 => 0.2, //학생 & 18세 미만
                ("학생", _) => 0.1, //학생 & 18세 이상
                ("일반", int n) when n < 18 => 0.1, //일반 & 18세 미만
                ("일반", _) => 0.05, //일반 & 18세 이상
                _ => 0,
            };
        }

        static void Main(string[] args)
        {
            var person = ("슈퍼맨", 9999);//명명되지 않은 튜플

            var person2 = (Name: "나현정", Age: 23);//명명된 튜플
            WriteLine($"{person2.Name}, {person2.Age}");

            var (name, age) = person2;//분해 var name, var age = person2
            WriteLine($"{name}, {age}");

            var (name2, age2) = ("나형진", 21);
            WriteLine($"{name2}, {age2}");

            WriteLine("================================");

            var alice = (job: "학생", age: 17);
            var bob = (job: "학생", age: 23);
            var charlie = (job: "학생", age: 21);
            var dave = (job: "학생", age: 33);

            WriteLine($"alice : {GetDiscountRate(alice)}");
            WriteLine($"bob : {GetDiscountRate(bob)}");
            WriteLine($"charlie : {GetDiscountRate(charlie)}");
            WriteLine($"dave : {GetDiscountRate(dave)}");
        }
    }
}
