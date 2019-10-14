using System;

namespace GaryGarage
{
    public class Zero : Vehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {

        }

        public override void Drive()
        {
            Console.WriteLine("The zero goes Vroom Vroom!");
        }
    }
}




