using System;
using static System.Console;

namespace MultiInterfaceInheritance
{
    interface IRunnable
    {
        void Run();
    }
    interface IFlyable
    {
        void Fly();
    }

    class Plane : IFlyable
    {
        public void Fly()
        {
            WriteLine("다중 상속 흉내 내기 : Fly!"); 
        }
    }
    class Car : IRunnable
    {
        public void Run()
        {
            WriteLine("다중 상속 흉내 내기 : Run!");
        }
    }
    class FlyingCar : IFlyable, IRunnable
    {
        Car car = new Car();
        Plane plane = new Plane();

        public void Fly()
        {
            WriteLine("Fly! Fly!");
        }

        public void Run()
        {
            WriteLine("Run! Run!");
        }

        public void RunC()
        {
            car.Run();
        }
        public void FlyC()
        {
            plane.Fly();
        }
        
    }
    class MainApp
    {
        static void Main2(string[] args)
        {
            FlyingCar flyingCar = new FlyingCar();
            flyingCar.Run();
            flyingCar.Fly();

            flyingCar.RunC();
            flyingCar.FlyC();
        }
    }
}
