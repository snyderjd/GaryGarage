using System;
using System.Collections.Generic;

namespace GaryGarage
{
    public class GasStation : IStation<IGasVehicle>
    {
        public int Capacity { get; set; }

        public GasStation(int capacity)
        {
            Capacity = capacity;
        }

        public void Refuel(List<IGasVehicle> vehicles)
        {
            if (vehicles.Count <= Capacity)
            {
                foreach (IGasVehicle vehicle in vehicles)
                {
                    vehicle.RefuelTank();
                }
            }
            else
            {
                Console.WriteLine($"Too many vehicles to refuel. Can only refuel {Capacity} vehicles at a time.");
            }
            
        }
    }
}