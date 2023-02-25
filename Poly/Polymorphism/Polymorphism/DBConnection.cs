internal partial class Program
{
    public abstract class DBConnection
    {
        private readonly string _connectionString;
        public TimeSpan timeSpan { get; set; }

        public DBConnection(string connectionString)
        {
            this._connectionString = string.IsNullOrEmpty(connectionString) ? throw new NullReferenceException("connection string cannot be null") : connectionString;
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }
}