using Domain.Entities;
using Domain.Interfaces.Leads.Services;
using Domain.Interfaces.Leads.UseCases;
using Infraestructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplication.UseCases.Leads
{
    public class GetLeadsUseCase : IGetLeadsUseCase
    {
        private IGetLeadsService _IGetLeadsService;

        public GetLeadsUseCase(IGetLeadsService GetLeadsService)
        {
            _IGetLeadsService = GetLeadsService;
        }

        public async Task<List<LeadsEntity>> GetLeadsAsync()
        {
            var result = await _IGetLeadsService.GetLeadsAsync();
            return result.ToList();
        }

        public async Task<List<LeadsEntity>> GetInvitedAsync()
        {
            var result = await _IGetLeadsService.GetInvitedAsync();
            return result.ToList();
        }

        public async Task<List<LeadsEntity>> GetAcceptedAsync()
        {
            var result = await _IGetLeadsService.GetAcceptedAsync();
            return result.ToList();
        }
    }

}
