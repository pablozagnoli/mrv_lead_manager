using Domain.Entities;
using Domain.Interfaces.Leads.Repository;
using Domain.Interfaces.Leads.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class DeclineLeadService : IDeclineLeadService
    {
        private ILeadsRepository _LeadsRepository;
        public DeclineLeadService(ILeadsRepository LeadsRepository)
        {
            _LeadsRepository = LeadsRepository;
        }

        public int DeclineLead(LeadsEntity lead)
        {
            var result = _LeadsRepository.UpdateLead(lead);
            return result;
        }
    }
}
