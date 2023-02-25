internal partial class Program
{
    private static void Main(string[] args)
    {
        var dbMigrator = new dbMigrator(new FileLogger("log.txt"));

        dbMigrator.Migrate();
    }
}