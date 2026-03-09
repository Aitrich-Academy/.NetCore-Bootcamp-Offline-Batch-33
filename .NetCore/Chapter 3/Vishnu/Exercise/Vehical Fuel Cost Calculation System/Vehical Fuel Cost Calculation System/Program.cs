using Vehical_Fuel_Cost_Calculation_System.NewFolder;
using Vehical_Fuel_Cost_Calculation_System.Types_of_vehicles;

internal class Program
{
    private static void Main(string[] args)
    {
        double distance = 300.8;

        Vehicle[] vehicles = new Vehicle[4];

        vehicles[0] = new Car(1, "Toyota Cruze");
        vehicles[1] = new Car(2, "Ford GT");
        vehicles[2] = new Bike(3, "KTM RC 990");
        vehicles[3] = new Bike(4, "Honda Fire Blade");

        Console.WriteLine("======Vehicle Fuel Cost======");

        for (int i = 0; i < vehicles.Length; i++)
        {
            double cost = vehicles[i].CalculateFuelCost(distance);

            Console.WriteLine("Vehicle ID: " + vehicles[i].vehicleId);
            Console.WriteLine("Vehicle Name: " + vehicles[i].vehicleName);
            Console.WriteLine("Fuel Cost for " + distance + " km: $" + cost);
            Console.WriteLine();
        }

    }
}