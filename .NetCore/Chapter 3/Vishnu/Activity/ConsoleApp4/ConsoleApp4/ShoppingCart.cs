using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp4
{
    public class ShoppingCart : IShoppingCart
    {

        List<Product> products = new List<Product>();

      

        public void AddProduct(Product product )
        {
            
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        public void CalculateTotalPrice()
        {
            double totalPrice = 0;

            foreach (Product p in products)
            {
                totalPrice += p.price;
            }
        }

        public void DisplayCartContents()
        {
            foreach (Product p in products)
            {
                p.DisplayInfo();
            }
        }

    }
}