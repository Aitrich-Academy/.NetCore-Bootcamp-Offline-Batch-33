using System;
using System.Collections.Generic;
using System.Text;
using Vehical_Fuel_Cost_Calculation_System.NewFolder;

namespace Vehical_Fuel_Cost_Calculation_System.Types_of_vehicles
{
    internal class Bike : Vehicle
    {
        public Bike(int vehicleId, string vehicleName)
            : base(vehicleId, vehicleName)
        {

        }

        private double FuelCost(double distance)
        {
            return distance * 0.07;
        }

        public override double CalculateFuelCost(double distance)
        {
            return FuelCost(distance);
        }
    }
}
