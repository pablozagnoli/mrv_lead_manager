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
        public List<LeadsEntity> GetLeads()
        {
            var result = _IGetLeadsService.getLeads();
            return result.ToList();
        }

        public List<LeadsEntity> GetInvited()
        {
            var result = _IGetLeadsService.GetInvited();
            return result.ToList();
        }

        public List<LeadsEntity> GetAccepted()
        {
            var result = _IGetLeadsService.GetAccepted();
            return result.ToList();
        }
    }
}
