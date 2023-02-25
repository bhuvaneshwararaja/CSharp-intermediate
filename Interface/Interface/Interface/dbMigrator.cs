internal partial class Program
{
    public class dbMigrator
    {
        private readonly ILogger log;

        public dbMigrator(ILogger log)
        {
            this.log = log;
        }

        public void Migrate()
        {
            log.logInfo("Migrating starts at : " + DateTime.Now);

            log.logInfo("Migrating finished at : " + DateTime.Now);

        }
    }
}