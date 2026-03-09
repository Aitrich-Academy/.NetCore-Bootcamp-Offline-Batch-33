using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class ElectronicProduct : Product
    {
        public int WarrantyPeriod;

        public ElectronicProduct (int WarrantyPeriod,double price) 
            : base (price)
        {
            this.WarrantyPeriod = WarrantyPeriod;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("WarrantyPeriod" +" "+ WarrantyPeriod);
            Console.WriteLine("price" + " "+ price);
        }



       
    }
}
