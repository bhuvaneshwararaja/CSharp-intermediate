internal partial class Program
{
    private static void Main(string[] args)
    {
        //database connection polymorphism exe

        var sql = new SqlConnection("http://localhost:600");
        var oracle = new OracleConnection("http://localhost:700");

        var command = new DBCommand(sql, "Insert into database");
        command.execute();
        
    }
}