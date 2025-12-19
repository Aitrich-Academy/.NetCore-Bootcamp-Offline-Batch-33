namespace encapsulation3
{
    internal class Program
    {
        public class Product
        {
            private string _name;
            private double _price;
            private int _stockquantity;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }
            public double Price
            {
               get { return _price; }
                set { _price = value; }
            }
            public Product(string name, double price,int stockquantity)
            {
                _name = name;
                _price = price;
                _stockquantity = stockquantity;
            }
            public void Purchase(int quantity)
            {
                if (quantity > 0 && quantity<=_stockquantity)
                {
                    _stockquantity-=quantity;
                    Console.WriteLine($"Purchased {quantity} unit(s) of {_name}");
                }
                else
                {
                    Console.WriteLine("insufficient stock or invalid quantity.");
                }
            }
            public int getStock()
            {
                return _stockquantity;
            }
        }
        static void Main(string[] args)
        {
            Product laptop = new Product("Laptop", 800, 10);
            laptop.Purchase(3);
            Console.WriteLine($"remaining stock :{laptop.getStock()}");
        }
    }
}
