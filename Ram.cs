using System;

namespace GaryGarage
{
    public class Ram : Vehicle
    {  // Gas powered truck
        public double FuelCapacity { get; set; }
        // public void RefuelTank() { ... }

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