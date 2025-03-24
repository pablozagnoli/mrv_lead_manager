using Domain.Entities;
using Domain.Interfaces.Leads.Services;
using Domain.Interfaces.Leads.UseCases;
using Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.UseCases.Leads
{
    public class UpdateLeadUseCase : IUpdateLeadUseCase
    {
        private IUpdateLeadService _LeadsService;

        public UpdateLeadUseCase(IUpdateLeadService LeadsService)
        {
            _LeadsService = LeadsService;
        }
        public int UpdateLead(LeadsEntity lead)
        {
            if (lead.Price > 500)
            {
                lead.Price = lead.Price - (lead.Price / 10);
            }
            var result = _LeadsService.UpdateLead(lead);
            return result;
        }
    }
}
