using System.Collections;
using System.Collections.Generic;

namespace _06_GenericInventory;

class Inventory<T> : IEnumerable<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {   
        items.Add(item);
    }

    public void ShowCount()
    {
        System.Console.WriteLine($"Count : {items.Count}");
    }

    public IEnumerator<T> GetEnumerator()
    {
        return items.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}