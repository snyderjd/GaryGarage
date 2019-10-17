using System;

namespace GaryGarage
{
    public class Zero : Vehicle, IElectricVehicle // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public void ChargeBattery()
        {

        }

        public override void Drive()
        {
            Console.WriteLine("The zero goes Vroom Vroom!");
        }

        public void RechargeBattery()
        {
            Console.WriteLine("The Zero has been recharged!");
        }
    }
}




