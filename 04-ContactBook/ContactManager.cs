using System.Collections.Generic;

namespace _04_ContactBook;

class ContactManager
{
    private Dictionary<string, string> contacts =  new Dictionary<string, string>();

    public void AddContact(string name, string phoneNumber)
    {
        if(contacts.ContainsKey(name))
        {
            System.Console.WriteLine("Contact already exists no need to add it");
            return;
        }
        contacts.Add(name,phoneNumber);
    }

    public void ShowContacts()
    {
        foreach(var contact in contacts)
        {
            System.Console.WriteLine($"Name : {contact.Key}  ," +
            $"Phone number : {contact.Value}"
            );
        }
    }

    public void FindContact(string name)
    {
        var phonetry = contacts.TryGetValue(name,out string? vv);
        if(!phonetry)
        {
            System.Console.WriteLine("THE PHONE NUMBER DOESNT EXIST PLEASE ADD IT ");
            return;
        }
        System.Console.WriteLine($"Phone number with the value found and its number is {vv}");
    }

    public void UpdateContact(string name, string newPhoneNumber)
    {
        var phonetry = contacts.TryGetValue(name,out string? vv);
        if(!phonetry)
        {
            System.Console.WriteLine("THE PHONE NUMBER DOESNT EXIST PLEASE ADD IT ");
            return;
        }
        contacts[name] = newPhoneNumber;
    }

    public void RemoveContact(string name)
    {
        var phonetry = contacts.TryGetValue(name,out string? vv);
        if(!phonetry)
        {
            System.Console.WriteLine("THE PHONE NUMBER DOESNT EXIST AND CANT BE DELETED");
            return;
        }
        contacts.Remove(name);
    }



}