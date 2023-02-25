internal partial class Program
{
    public class ConsoleLogger : ILogger
    {

        public void logInfo(string message)
        {
            log(message);
        }

        public void logError(string message)
        {
            log(message);
        }

        public void log(string message)
        {
            if (string.IsNullOrEmpty(message))
                throw new ArgumentNullException("message cannot be empty");

            Console.WriteLine(message);
        }
    }
}