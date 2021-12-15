using System;
using static System.Console;

namespace Overriding
{
    class ArmorSuite
    {
        //오버라이딩을 하고 싶다면(다형성을 만족시키고 싶다면)
        //오버라이딩 대상 메소드가 virtual 키워드로 한정되어 있어야 한다
        public virtual void Initialize()
        {
            WriteLine("Armored");
        }
    }

    class IronMan : ArmorSuite
    {
        //public override void Initialize()
        public new void Initialize() //기반(부모) 클래스의 내용을 숨기는 방법 = new 한정자로 수식하기
        {
            //base.Initialize();
            WriteLine("Repulsor Rays Armed");
        }
    }

    class WarMachine : ArmorSuite
    {
        //public override void Initialize()
        public new void Initialize()
        {
            //base.Initialize();
            WriteLine("Double-[Barrel Cannons Armed");
            WriteLine("Micro-Rocket Launcher Armed");
        }
    }

    class MainApp
    {
        static void Main8(string[] args)
        {
            WriteLine("Creating ArmorSuite...");
            ArmorSuite armorSuite = new ArmorSuite();
            armorSuite.Initialize();

            WriteLine("\nCreating IronMan...");
            //ArmorSuite ironman = new IronMan();
            IronMan ironman = new IronMan(); //기반 클래스의 내용을 이제는 볼 수 없음 -> new 한정자의 영향
            ironman.Initialize();

            WriteLine("\nCreating WarMachine...");
            //ArmorSuite warmachine = new WarMachine();
            WarMachine warmachine = new WarMachine(); //기반 클래스의 내용을 이제는 볼 수 없음 -> new 한정자의 영향
            warmachine.Initialize();

        }
    }
}
