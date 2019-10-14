using System;

namespace GaryGarage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of each vehicle
            Zero zero1 = new Zero();
            Tesla tesla1 = new Tesla();
            Cessna cessna1 = new Cessna();
            Ram ram1 = new Ram();

            // Define a different value for each vehicle's properties
            zero1.MainColor = "gray";
            zero1.MaximumOccupancy = "1";

            tesla1.MainColor = "red";
            tesla1.MaximumOccupancy = "4";

            cessna1.MainColor = "white";
            cessna1.MaximumOccupancy = "3";

            ram1.MainColor = "black";
            ram1.MaximumOccupancy = "4";

            // Make your vehicle instances perform all three behaviors
            ram1.Drive();
            ram1.Turn("left");
            ram1.Stop();

            zero1.Drive();
            zero1.Turn("right");
            zero1.Stop();

            cessna1.Drive();
            cessna1.Turn("left");
            cessna1.Stop();

            tesla1.Drive();
            tesla1.Turn("right");
            tesla1.Stop();



        }
    }
}
