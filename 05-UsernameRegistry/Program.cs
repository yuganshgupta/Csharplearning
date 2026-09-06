namespace _05_UsernameRegistry;

class Program
{
    static void Main(string[] args)
    {
        var manager = new UsernameManager();

        manager.AddUsername("Yugansh");
        manager.AddUsername("Yash");
        manager.AddUsername("Suyash");

        manager.AddUsername("Yugansh");
    
        Console.WriteLine("\nAll usernames:");
        manager.ShowUsernames();

        Console.WriteLine("\nFinding username:");
        manager.FindUsername("Yash");
        manager.FindUsername("Nikhil");

        Console.WriteLine("\nRemoving username:");
        manager.RemoveUsername("Suyash");
        manager.RemoveUsername("RandomUser");

        Console.WriteLine("\nUsernames after removal:");
        manager.ShowUsernames();
    }
}