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
        IEnumerable<LeadsEntity> getLeads();
        IEnumerable<LeadsEntity> GetInvited();
        IEnumerable<LeadsEntity> GetAccepted();

        int UpdateLead(LeadsEntity lead);
    }
}
