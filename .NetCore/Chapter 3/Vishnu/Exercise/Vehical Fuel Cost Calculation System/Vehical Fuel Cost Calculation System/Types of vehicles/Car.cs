using System;
using System.Collections.Generic;
using System.Text;
using Vehical_Fuel_Cost_Calculation_System.NewFolder;

namespace Vehical_Fuel_Cost_Calculation_System.Types_of_vehicles
{
    internal class Car : Vehicle
    {
        public Car(int vehicleId, string vehicleName)
            : base(vehicleId, vehicleName)
        {

        }

        private double FuelCost(double distance)
        {
            return distance * 0.15;
        }

        public override double CalculateFuelCost(double distance)
        {
            return FuelCost(distance);
        }
    }
}
