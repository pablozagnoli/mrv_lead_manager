using Aplication.UseCases.Leads;
using Domain.Interfaces.Leads;
using Domain.Services;
using Infraestructure.Repositories;
using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Infrastructure.Data;
using System.Data.SqlClient;
using System.Data;

namespace mrv_lead_manager_back.Configuration
{
    public static class DependencyInjection
    {

        public static void AddApplicationServices(this IServiceCollection services, string connectionString)
        {
            // Adicionando a conexão ao banco de dados
            services.AddSingleton(new DbConnectionFactory(connectionString));

            services.AddScoped<IDbConnection>(provider =>
            {
                return new SqlConnection(connectionString);
            });

            // Registrando os repositórios
            services.AddScoped<ILeadsRepository, LeadsRepository>();

            // Registrando os casos de uso
            services.AddScoped<IGetLeadsUseCase, GetLeadsUseCase>();
            services.AddScoped<IUpdateLeadUseCase, UpdateLeadUseCase>();

            // Registrando outros serviços (se houver)
            services.AddScoped<IGetLeadsService, GetLeadsService>();
        }

    }
}
