using System.Collections.Generic;

namespace _05_UsernameRegistry;

class UsernameManager
{
    private HashSet<string> usernames = new HashSet<string>();

    public void AddUsername(string username)
    {
         var add = usernames.Add(username);
         if(!add)
        {
            System.Console.WriteLine("Please enter a unique username for this data type"    );
        }
    }

    public void ShowUsernames()
    {
        foreach(var username in usernames)
        {
            System.Console.WriteLine($"User is  : {username}");
        }
    }

    public void FindUsername(string username)
    {
        if(usernames.Contains(username))
        {
            System.Console.WriteLine($"{username} found in the hash set");
            return;
        }
        System.Console.WriteLine($"Username not found in the hashset");
    }

    public void RemoveUsername(string username)
    {
        var remove = usernames.Remove(username);
        if (!remove)
        {
        Console.WriteLine("Username not found");
        return;
        }

        Console.WriteLine($"Username {username} removed successfully");
    }
}