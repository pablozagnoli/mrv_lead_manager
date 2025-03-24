using Aplication.UseCases.Leads;
using Domain.Services;
using Infraestructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MyApp.Infrastructure.Data;
using Domain.Interfaces.Leads.Services;
using Domain.Interfaces.Leads.UseCases;
using Domain.Interfaces.Leads.Repository;

namespace mrv_lead_manager_back.Configuration
{
    public static class DependencyInjection
    {
        public static void AddApplicationServices(this IServiceCollection services, string connectionString)
        {
            // Adicionando o DbContext para Entity Framework Core
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            // Registrando os repositórios com EF Core
            services.AddScoped<ILeadsRepository, LeadsRepository>();

            // Registrando os casos de uso
            services.AddScoped<IGetLeadsUseCase, GetLeadsUseCase>();
            services.AddScoped<IAcceptLeadUseCase, AcceptLeadUseCase>();
            services.AddScoped<IDeclineLeadUseCase, DeclineLeadUseCase>();

            // Registrando serviços
            services.AddScoped<IGetLeadsService, GetLeadsService>();
            services.AddScoped<IDeclineLeadService, DeclineLeadService>();
            services.AddScoped<IAcceptLeadService, AcceptLeadService>();
            services.AddScoped<IMailService, MailService>();
        }
    }
}
