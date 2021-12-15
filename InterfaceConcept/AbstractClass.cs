using System;
using static System.Console;
/**
 * 추상 클래스는 구현을 가질 수 있음
 * 추상 클래스는 인스턴스를 만들지 못함
 */
namespace InterfaceConcept
{
    abstract class AbstractBase //추상 클래스
    {
        protected void privateMethodA()
        {
            WriteLine("AbstractBase.privateMethodA()");
        }
        public void publicMethodA()
        {
            WriteLine("AbstractBase.publicMethodA()");
        }
        public abstract void abstractMethodA(); //추상 메소드
    }

    class Derived : AbstractBase //추상 클래스를 상속 받음
    {
        public override void abstractMethodA()
        {
            WriteLine("Derived.abstractMethodA()");
            privateMethodA();
        }
    }

    class MainApp
    {
        static void Main3(string[] args)
        {
            AbstractBase obj = new Derived();
            
            obj.abstractMethodA();
            obj.publicMethodA();
        }
    }
}
