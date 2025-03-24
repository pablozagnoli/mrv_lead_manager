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
        public async Task<int> AcceptLeadAsync(LeadsEntity lead)
        {
            var result = await _AcceptLeadService.AcceptLeadAsync(lead);
            return result;
        }
    }
}
