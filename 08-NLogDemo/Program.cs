namespace _08_NLogDemo;

using NLog;

internal class Program
{
    private static readonly Logger logger =
        LogManager.GetCurrentClassLogger();  // asking for the Nlogger associated with the current class 

    static void Main(string[] args)
    {
        LogManager.Setup()
            .LoadConfigurationFromFile("NLog.config"); // Basically defines how Nlog should behave and all

        logger.Trace("Trace message");
        logger.Debug("Debug message");
        logger.Info("Application started");
        logger.Warn("Warning");
        logger.Error("Error");
        logger.Fatal("Fatal");

        ExceptionDemo.Run(); // Runs the function in ExceptionDemo.cs
    }
}