using System;
using System.Collections.Generic;
using System.Text;

namespace Vehical_Fuel_Cost_Calculation_System.NewFolder
{
    internal abstract class Vehicle
    {
        public int vehicleId {  get; set; }
        public string vehicleName {  get; set; }

        public abstract double CalculateFuelCost(double distance);

        public Vehicle (int vehicleId, string vehicleName)
        {
            this.vehicleId = vehicleId;
            this.vehicleName = vehicleName;
        }   
    }
}
