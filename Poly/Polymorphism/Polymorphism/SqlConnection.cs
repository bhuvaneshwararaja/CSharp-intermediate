internal partial class Program
{
    public class SqlConnection:DBConnection
    {
        private string _connectionString;

        public SqlConnection(string connectionString)
        :base(connectionString)
        {
            this._connectionString = string.IsNullOrEmpty(connectionString) ? throw new NullReferenceException("connection string cannot be null") : connectionString;

        }

        public override void OpenConnection()
        {
            Console.WriteLine("SQL connection is opened at {0}",_connectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("SQL connection is closed for {0}", _connectionString);

        }
    }
}