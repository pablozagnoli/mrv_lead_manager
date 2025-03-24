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
    public class DeclineLeadUseCase : IDeclineLeadUseCase
    {
        private IDeclineLeadService _LeadsService;

        public DeclineLeadUseCase(IDeclineLeadService LeadsService)
        {
            _LeadsService = LeadsService;
        }
        public int DeclineLead(LeadsEntity lead)
        {
            var result = _LeadsService.DeclineLead(lead);
            return result;
        }
    }
}
