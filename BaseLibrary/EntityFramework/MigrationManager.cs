using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BaseLibrary.EntityFramework
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var plantLogsheetContext = scope.ServiceProvider.GetRequiredService<PlantLogsheetsContext>())
                {
                    try
                    {
                        plantLogsheetContext.Database.Migrate();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return host;
        }
    }
}
