using Microsoft.Extensions.Configuration;

namespace _07_ConfigLoggingDemo;

internal class Program
{
    static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")
            .AddJsonFile("appsettings.Local.json")
            .Build();

        //string? appname = configuration["AppName"]; // here configuration represented the whole root section 
        //int maxRetries = configuration.GetValue<int>("MaxRetries");


        // var appSettings = configuration.GetSection("AppSettings");

        // string? appName = appSettings["AppName"]; // now this is inside appsettings and its a nested configuration 
        // int maxRetries = appSettings.GetValue<int>("MaxRetries");

        AppSettings? settings = configuration // take only this part of config
        .GetSection("AppSettings") // create an AppSettings object
        .Get<AppSettings>(); // matches AppName -> AppName and MaxRetries -> MaxRetries

        Console.WriteLine(settings?.AppName);
        Console.WriteLine(settings?.MaxRetries);

    }
}