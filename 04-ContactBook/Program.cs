namespace _04_ContactBook;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");
        var manager = new ContactManager();

        manager.AddContact("Yugansh", "9876543210");
        manager.AddContact("Suyash", "9123456780");
        manager.AddContact("Kunal", "9988776655");

        Console.WriteLine("All Contacts:");
        manager.ShowContacts();

        Console.WriteLine("Finding Contact:");
        manager.FindContact("Kunal");

        Console.WriteLine("Updating Contact:");
        manager.UpdateContact("Suyash", "123456");
        manager.FindContact("Suyash");

        Console.WriteLine("Removing Contact:");
        manager.RemoveContact("Suyash");

        Console.WriteLine("Contacts After Removal:");
        manager.ShowContacts();

        Console.WriteLine("Searching Missing Contact:");
        manager.FindContact("Nikhil");
    }
}
