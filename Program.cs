using System;
using System.Collections.Generic;

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
            Zero zero2 = new Zero();
            Tesla tesla2 = new Tesla();
            Cessna cessna2 = new Cessna();
            Ram ram2 = new Ram();


            // Define a different value for each vehicle's properties
            zero1.MainColor = "gray";
            zero1.MaximumOccupancy = "1";
            zero2.MainColor = "white";
            zero2.MaximumOccupancy = "1";

            tesla1.MainColor = "red";
            tesla1.MaximumOccupancy = "4";
            tesla2.MainColor = "blue";
            tesla2.MaximumOccupancy = "4";

            cessna1.MainColor = "white";
            cessna1.MaximumOccupancy = "3";
            cessna2.MainColor = "white";
            cessna2.MaximumOccupancy = "3";

            ram1.MainColor = "black";
            ram1.MaximumOccupancy = "4";
            ram2.MainColor = "gray";
            ram2.MaximumOccupancy = "4";

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

            // Make a list of electric vehicles and a list of gas vehicles
            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>()
            {
                zero1, zero2, tesla1
            };

            List<IGasVehicle> gasVehicles = new List<IGasVehicle>()
            {
                ram1, ram2, cessna1
            };

            // Instantiate a battery station and a gas station
            BatteryStation kwikCharge = new BatteryStation(4);
            GasStation kwikFuel = new GasStation(8);

            // Have the stations recharge/refuel a list of vehicles
            kwikCharge.Refuel(electricVehicles);
            Console.WriteLine();
            kwikFuel.Refuel(gasVehicles);



        }
    }
}
