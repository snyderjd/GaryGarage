using System;

namespace GaryGarage
{
    public class Ram : Vehicle, IGasVehicle
    {  // Gas powered truck
        public double FuelCapacity { get; set; }
        // public void RefuelTank() { ... }
        public void RefuelTank()
        {
            Console.WriteLine("The ram truck has been refueled!");
        }

        public override void Drive()
        {
            Console.WriteLine("The ram goes VROOOM!");
        }

        public override void Turn(string direction)
        {
            Console.WriteLine($"The {MainColor} Ram turned {direction}");
        }
    }
}