using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public class groceryProduct : Product
    {
        public int ExpirationDate;

        public groceryProduct(int ExpirationDate,double price)
           : base(price)
        {
            this.ExpirationDate = ExpirationDate;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine("price" + "" + price);
            Console.WriteLine("expiry date" + " " + ExpirationDate);
           
        }
        

    }
}
