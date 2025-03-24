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
    public class UpdateLeadService : IUpdateLeadService
    {

        private ILeadsRepository _LeadsRepository;
        public UpdateLeadService(ILeadsRepository LeadsRepository)
        {
            _LeadsRepository = LeadsRepository;
        }

        public int UpdateLead(LeadsEntity lead)
        {
            if (lead.Price > 500)
            {
                lead.Price = lead.Price - (lead.Price / 10);
            }
            var result = _LeadsRepository.UpdateLead(lead);
            return result;
        }
    }
}
