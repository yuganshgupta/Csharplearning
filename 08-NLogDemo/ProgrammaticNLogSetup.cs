namespace _08_NLogDemo;

using NLog;
using NLog.Config;
using NLog.Targets;

internal class ProgrammaticNLogSetup
{
    // asking for the Nlogger associated with the current class 
    private static readonly Logger logger = LogManager.GetCurrentClassLogger();

    public static void Run()
    {
        Console.WriteLine(logger.Name);

        // Basically defines how Nlog should behave and all
        var config = new LoggingConfiguration();

        // This is where we define the target of the logger -> Where the log should go 
        //var console = new ConsoleTarget("console");

        //Defining the target of the log along with how it should be formatted
        var console = new ConsoleTarget("console")
        {
            Layout = "${longdate} | ${level:uppercase=true} | ${message}" // -> the way to write messages in CONSOLE 
        };

        var Filew = new FileTarget("Filew")
        {
            FileName = "${basedir}/logs/app.log", // Telling where the file should be placed 
            Layout = "${longdate} | ${level:uppercase=true} | ${logger} | ${message} | ${exception:format=tostring}"
            // will also print the exception message when called the function from exceptiondemo.cs
        };

        // sends the log that are Info through Fatal to the console just like how we defined in console 
        config.AddRule(
            LogLevel.Info,
            LogLevel.Fatal, // This would include Info Warn Error and Fatal
            console         // -> Determines the output where its going to be displayed or logged 
        );

        config.AddRule(
            LogLevel.Info,
            LogLevel.Fatal,
            Filew  // This would include Info Warn Error and Fatal
                   // 08-NLogDemo/bin/Debug/net10.0/logs/app.log
        );

        // NLog treats the levels roughly like this, from least severe / most verbose to most severe:
        // Trace -> Debug -> Info -> Warn -> Error -> Fatal

        // basically tells Nlog to use the configuration we made 
        LogManager.Configuration = config;

        //Loging the information to the console just like we set our target 
        logger.Trace("Trace messages");
        logger.Debug("Debugging Messages");
        logger.Info("Application started");
        logger.Warn("Warning");
        logger.Error("Error");
        logger.Fatal("Fatal");

        ExceptionDemo.Run();
    }
}