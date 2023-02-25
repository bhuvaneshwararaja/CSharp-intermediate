internal partial class Program
{
    public class FileLogger : ILogger
    {
        private readonly string _path;

        public FileLogger(string path)
        {
            _path = string.IsNullOrEmpty(path) ? throw new NullReferenceException("Path cannot be empty !!1") : path;
        }

        public void logInfo(string message)
        {
            log(message, nameof(EMessageType.INFO));
        }

        public void logError(string message)
        {
            log(message,nameof(EMessageType.ERROR));
        }

        public void log(string message, string messageType)
        {
            using (var streamWriter = new StreamWriter(_path,true)) // it will automatically call disposal method
            {
                streamWriter.WriteLine(message);
            }
        }
    }
}