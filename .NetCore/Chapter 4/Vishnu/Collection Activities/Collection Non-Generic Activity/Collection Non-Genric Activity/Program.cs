using System;
using System.Collections;

internal class Program
{
    public static void Main(string[] args)
    {

        ArrayList trackingNumbers = new ArrayList();

        trackingNumbers.Add("ABC123456789");  
        trackingNumbers.Add("XYZ987654321");
        trackingNumbers.Add("DEF456789123");
        trackingNumbers.Add("GHI789123456");
        trackingNumbers.Add("JKL321654987");

        Console.WriteLine(" Tracking Numbers :");
        foreach (string track in trackingNumbers)
        {
            Console.WriteLine($"  {track}");
        }

        Console.WriteLine("\n======================================");


        Hashtable shipmentDetails = new Hashtable();

        shipmentDetails["ABC123456789"] = "Sender: Vishnu S, Receiver: Priya K, Status: In Transit, Weight: 2.5kg";
        shipmentDetails["XYZ987654321"] = "Sender: Arjun M, Receiver: Swati R, Status: Delivered, Weight: 1.8kg";
        shipmentDetails["DEF456789123"] = "Sender: Kabir S, Receiver: Manas P, Status: Pending Payment, Weight: 4.2kg";
        shipmentDetails["GHI789123456"] = "Sender: Lakshmi N, Receiver: Rajesh T, Status: Out for Delivery, Weight: 3.1kg";
        shipmentDetails["JKL321654987"] = "Sender: Deepak V, Receiver: Anjali S, Status: Delayed, Weight: 5.0kg";

        Console.WriteLine(" Shipment Details (Hashtable):");
        foreach (DictionaryEntry detail in shipmentDetails)
        {
            Console.WriteLine($"  {detail.Key}: {detail.Value}");
        }

        Console.WriteLine($"\nQuick lookup - DEF456789123: {shipmentDetails["DEF456789123"]}");

        Console.WriteLine("\n======================================");


        SortedList deliverySchedule = new SortedList();

        deliverySchedule.Add("2026-03-12 10:30 AM", "ABC123456789");
        deliverySchedule.Add("2026-03-13 02:15 PM", "GHI789123456");
        deliverySchedule.Add("2026-03-14 09:45 AM", "JKL321654987");
        deliverySchedule.Add("2026-03-15 11:20 AM", "XYZ987654321");
        deliverySchedule.Add("2026-03-16 03:30 PM", "DEF456789123");

        Console.WriteLine(" Delivery Schedule (SortedList):");
        foreach (DictionaryEntry delivery in deliverySchedule)
        {
            Console.WriteLine($"  {delivery.Key}: {delivery.Value}");
        }

        Console.WriteLine("\n======================================");


        Queue incomingOrders = new Queue();

        incomingOrders.Enqueue("New order: TRK-ABC123 from Mumbai to Kochi");
        incomingOrders.Enqueue("New order: TRK-XYZ987 from Delhi to Chennai");
        incomingOrders.Enqueue("New order: TRK-DEF456 from Bangalore to Thrissur");
        incomingOrders.Enqueue("New order: TRK-GHI789 from Hyderabad to Kerala");
        incomingOrders.Enqueue("New order: TRK-JKL321 from Pune to Kanayannur");

        Console.WriteLine(" Incoming Orders Queue (FIFO):");
        foreach (string order in incomingOrders)
        {
            Console.WriteLine($"  {order}");
        }

        Console.WriteLine("\n======================================");


        Stack undoActions = new Stack();

        undoActions.Push("Undo: Cancelled TRK-JKL321 (Customer requested)");
        undoActions.Push("Undo: Rescheduled TRK-DEF456 to 2026-03-17");
        undoActions.Push("Undo: Updated TRK-XYZ987 address");
        undoActions.Push("Undo: Changed TRK-GHI789 delivery date");
        undoActions.Push("Undo: Modified TRK-ABC123 sender details");

        Console.WriteLine(" Undo Stack (LIFO):");
        foreach (string action in undoActions)
        {
            Console.WriteLine($"  {action}");
        }

        Console.WriteLine("\n======================================");
    }
}

