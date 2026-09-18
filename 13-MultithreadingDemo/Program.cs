namespace _13_MultithreadingDemo;
using System.Threading;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Thread worker = new Thread(Work);


        //worker.Start();
        //worker.Join();

        //for (int i = 0; i < 10; i++)
        //{
        //    Console.WriteLine($"Main {i} running");
        //    Thread.Sleep(10);
        //}

       
        
         RaceConditionDemo.Run();
        



    }

    static void Work()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"Worker {i} running");
            Thread.Sleep(10);
        }
    }
}
