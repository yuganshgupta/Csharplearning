using NLog;

namespace _08_NLogDemo;

internal static class ExceptionDemo
{
    private static readonly Logger logger =
        LogManager.GetCurrentClassLogger();

    public static void Run()
    {
        try
        {
            int a = 10;
            int b = 0;

            int result = a / b;
        }
        catch (Exception ex)
        {
            logger.Error(ex, "Something went wrong while dividing numbers");
        }
    }
}