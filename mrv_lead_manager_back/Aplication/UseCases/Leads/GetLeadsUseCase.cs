using Domain.Entities;
using Domain.Interfaces.Leads;
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

        private ILeadsRepository _LeadsRepository;

        public GetLeadsUseCase(ILeadsRepository LeadsRepository)
        {
            _LeadsRepository = LeadsRepository;
        }
        public List<LeadsEntity> GetLeads()
        {
            var result = _LeadsRepository.getLeads();
            return result.ToList();
        }
    }
}
