internal partial class Program
{
    public interface ILogger
    {
        void logInfo(string message);
        void logError(string message);
    }
}