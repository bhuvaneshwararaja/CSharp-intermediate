internal partial class Program
{
    public class OracleConnection:DBConnection
    {
        private string _connectionString;

        public OracleConnection(string connectionString)
            :base(connectionString)
        {
            this._connectionString = string.IsNullOrEmpty(connectionString) ? throw new NullReferenceException("connection string cannot be null") : connectionString;

        }

        public override void OpenConnection()
        {
            Console.WriteLine("Oracle connection is opened on {0}",_connectionString);
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Oracle connection is closed for {0}",_connectionString);

        }
    }
}