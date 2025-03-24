using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Leads.Repository
{
    public interface ILeadsRepository
    {
        Task<IEnumerable<LeadsEntity>> GetLeadsAsync();
        Task<IEnumerable<LeadsEntity>> GetInvitedAsync();
        Task<IEnumerable<LeadsEntity>> GetAcceptedAsync();

        Task<int> UpdateLeadAsync(LeadsEntity lead);
    }
}
