using Domain.Entities;
using Domain.Interfaces.Leads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.UseCases.Leads
{
    public class UpdateLeadUseCase : IUpdateLeadUseCase
    {
        private ILeadsRepository _LeadsRepository;

        public UpdateLeadUseCase(ILeadsRepository LeadsRepository)
        {
            _LeadsRepository = LeadsRepository;
        }
        public int UpdateLead(LeadsEntity lead)
        {
            if (lead.Price > 500)
            {
                lead.Price = lead.Price - (lead.Price / 10);
            }
            var result = _LeadsRepository.updateLead(lead);
            return result;
        }
    }
}
