using System;
using static System.Console;

namespace AccessModifier
{
    class WaterHeater
    {
        protected int temperature;

        public void setTemperature(int temperature)
        {
            if(temperature < -5 || temperature > 42)
            {
                throw new Exception("Out of temperature range");
            }
            this.temperature = temperature;
        }

        internal void turnOnWater()
        {
            WriteLine($"Turn On water : {temperature}");
        }
    }

    class MainApp
    {
        static void Main5(string[] args)
        {
            try
            {
                WaterHeater heater = new WaterHeater();

                heater.setTemperature(20);
                heater.turnOnWater();

                heater.setTemperature(-2);
                heater.turnOnWater();

                heater.setTemperature(50); //예외 발생 지역
                heater.turnOnWater();

            }
            catch (Exception e)
            {
                WriteLine(e.Message);
            }
        }
    }
}
