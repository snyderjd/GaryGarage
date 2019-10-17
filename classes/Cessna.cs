using System;

namespace GaryGarage
{
    public class Cessna : Vehicle, IGasVehicle // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }
        public void RefuelTank()
        {
            Console.WriteLine("The cessna has been refueled!");
        }

        public override void Drive()
        {
            Console.WriteLine("The Cessna goes Zoooom!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} cessna turned {direction}.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {MainColor} cessna landed safely on the runway.");
        }
    }
}
