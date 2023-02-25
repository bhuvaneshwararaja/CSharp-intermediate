internal partial class Program
{
    public class DBCommand
    {
        private DBConnection _dbConnection;
        public string instruction { get; set; }

        public DBCommand(DBConnection dbConnection, string instruction)
        {
            this._dbConnection = dbConnection == null ? throw new NullReferenceException("db connection cannot be null") : dbConnection;
            this.instruction = string.IsNullOrEmpty(instruction) ? throw new NullReferenceException("instruction cannot be empty") : instruction;
        }

        public void execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(instruction);
            _dbConnection.CloseConnection();
        }
    }
}