using System;

namespace Extensibility.Classes
{
    public class DbMigrator
    {
        private readonly ILogger _logger;

        public DbMigrator(ILogger logger)
        {
            _logger = logger;
        }
        public void Migrate()
        {
            _logger.LogInfo($"Migration started @ {DateTime.Now}");
            //Details of how to migrate here
            _logger.LogInfo($"Migration finished @ {DateTime.Now}");
        }
    }
}
