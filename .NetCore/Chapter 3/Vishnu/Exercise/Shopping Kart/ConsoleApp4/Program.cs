

using ConsoleApp4;

public abstract class Product
{
    public double price;

    public abstract void DisplayInfo();

    public Product(double price)
    {
        this.price = price;
    }

     


}
internal class Program
{
    private static void Main(string[] args)
    {
        ShoppingCart cart = new ShoppingCart();
        groceryProduct groc = new groceryProduct(12,2500);
        ElectronicProduct elec = new ElectronicProduct(22, 1200);


        cart.AddProduct(elec);
        cart.AddProduct(groc);

        cart.DisplayCartContents();
    }
}


