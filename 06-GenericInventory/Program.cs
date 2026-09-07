namespace _06_GenericInventory;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        var inv = new Inventory<Product>();


        var p1 = new Product(1,"SSD");
        var p2 = new Product(2,"HDD");
        var p3 = new Product(3,"GPU");

        inv.AddItem(p1);
        inv.AddItem(p2);
        inv.AddItem(p3);

        inv.ShowCount();
        // THIS method shows the coutn of the products we have added 

        System.Console.WriteLine("Products ");

        foreach(Product product in inv)
        {
            System.Console.WriteLine($"ID : {product.Id} and  Name : {product.Name}");
        }

        
    }
}
