using Aplication.UseCases.Leads;
using Domain.Services;
using Infraestructure.Repositories;
using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Infrastructure.Data;
using System.Data.SqlClient;
using System.Data;
using Domain.Interfaces.Leads.Services;
using Domain.Interfaces.Leads.UseCases;
using Domain.Interfaces.Leads.Repository;

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
            services.AddScoped<IAcceptLeadUseCase, AcceptLeadUseCase>();

            // Registrando serviços
            services.AddScoped<IGetLeadsService, GetLeadsService>();
            services.AddScoped<IDeclineLeadService, DeclineLeadService>();
            services.AddScoped<IAcceptLeadService, AcceptLeadService>();
            services.AddScoped<IMailService, MailService>();
        }

    }
}
