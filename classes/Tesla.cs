using System;

namespace GaryGarage
{
    public class Tesla : Vehicle, IElectricVehicle
    {  // Electric car
        public double BatteryKWh { get; set; }

        // public void ChargeBattery() { ... }

        public override void Drive()
        {
            Console.WriteLine("The Tesla goes _______");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Tesla turned {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} Tesla stopped.");
        }

        public void RechargeBattery()
        {
            Console.WriteLine("The Tesla has been recharged!");
        }
    }
}