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
    public class GetLeadsService : IGetLeadsService
    {
        private ILeadsRepository _LeadsRepository;
        public GetLeadsService(ILeadsRepository LeadsRepository)
        {
            _LeadsRepository = LeadsRepository;
        }

        public IEnumerable<LeadsEntity> getLeads()
        {
            var result = _LeadsRepository.getLeads();
            return result;
        }

        public IEnumerable<LeadsEntity> GetInvited()
        {
            var result = _LeadsRepository.GetInvited();
            return result;
        }

        public IEnumerable<LeadsEntity> GetAccepted()
        {
            var result = _LeadsRepository.GetAccepted();
            return result;
        }
    }
}
