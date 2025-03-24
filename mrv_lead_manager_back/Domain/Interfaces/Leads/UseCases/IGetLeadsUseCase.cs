using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Leads.UseCases
{
    public interface IGetLeadsUseCase
    {
        Task<List<LeadsEntity>> GetLeadsAsync();
        Task<List<LeadsEntity>> GetInvitedAsync();
        Task<List<LeadsEntity>> GetAcceptedAsync();
    }
}
