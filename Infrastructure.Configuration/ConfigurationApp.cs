using Microsoft.Extensions.DependencyInjection;
using Server.Domian;
using server.Infrastructure.Efcore;
using server.Infrastructure.Efcore.Repository;

namespace server.Infrastructure.Configuration;

public class ConfigurationApp
{
    public static void ConfingurationApplicationService(IServiceCollection service, string connectionString)
    {
        service.AddTransient<IPersonRepository, PersonRepository>();
        service.AddDbContext<PersonContext>();
    }
}