namespace _12_LaunchSettingsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string? mode = Environment.GetEnvironmentVariable("APP_MODE");

            Console.WriteLine($"Current mode: {mode}");
        }
    }
}
