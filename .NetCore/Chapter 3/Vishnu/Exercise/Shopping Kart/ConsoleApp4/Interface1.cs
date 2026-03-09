using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    public interface IShoppingCart
    {
        public void AddProduct(Product product);
        public void RemoveProduct(Product product);

        public void CalculateTotalPrice();

        public void DisplayCartContents();
    }
}
