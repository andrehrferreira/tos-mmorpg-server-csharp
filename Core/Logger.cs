using NLog;

namespace Server
{
    public static class Logger
    {
        static readonly ILogger _logger = LogManager.GetCurrentClassLogger();

        //static Client BugsnagClient;

        static Logger()
        {
            //BugsnagClient = new Bugsnag.Client(new Configuration(""));
        }

        public static void Log(Exception ex)
        {
            string logMessage = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {ex.Message}";

            _logger.Log(LogLevel.Info, ex, logMessage);

            Console.WriteLine(logMessage);

            try
            {
                //BugsnagClient.Notify(ex, Severity.Info);
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        public static void Log(string message)
        {
            string logMessage = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {message}";

            _logger.Log(LogLevel.Info, logMessage);

            Console.WriteLine(logMessage);
        }

        public static void Error(Exception ex)
        {
            string logMessage = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {ex.Message}";

            _logger.Error(ex, logMessage);

            Console.Error.WriteLine(ex.StackTrace);

            try
            {
                //BugsnagClient.Notify(ex, Severity.Error);
            }
            catch (Exception err)
            {
                Console.WriteLine(err);
            }
        }

        public static void Error(string message)
        {
            string logMessage = $"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] {message}";

            _logger.Log(LogLevel.Error, logMessage);

            Console.WriteLine(logMessage);
        }
    }
}
