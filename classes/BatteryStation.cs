using System;
using System.Collections.Generic;

namespace GaryGarage
{
    public class BatteryStation : IStation<IElectricVehicle>
    {
        public int Capacity { get; set; }

        public BatteryStation(int capacity)
        {
            Capacity = capacity;
        }

        public void Refuel(List<IElectricVehicle> vehicles)
        {

            if (vehicles.Count <= Capacity)
            {
                foreach (IElectricVehicle vehicle in vehicles)
                {
                    vehicle.RechargeBattery();
                }
            }
            else
            {
                Console.WriteLine($"Too many vehicles to recharge. Can only recharge {Capacity} vehicles at one time.");
            }
            
        }
    }
}