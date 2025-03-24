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
    public class AcceptLeadUseCase : IAcceptLeadUseCase
    {
        private IAcceptLeadService _AcceptLeadService;

        public AcceptLeadUseCase(IAcceptLeadService AcceptLeadService)
        {
            _AcceptLeadService = AcceptLeadService;
        }
        public int AcceptLead(LeadsEntity lead)
        {
            var result = _AcceptLeadService.AcceptLead(lead);
            return result;
        }
    }
}
