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

        public async Task<IEnumerable<LeadsEntity>> GetLeadsAsync()
        {
            return await _LeadsRepository.GetLeadsAsync();
        }

        public async Task<IEnumerable<LeadsEntity>> GetInvitedAsync()
        {
            return await _LeadsRepository.GetInvitedAsync();
        }

        public async Task<IEnumerable<LeadsEntity>> GetAcceptedAsync()
        {
            return await _LeadsRepository.GetAcceptedAsync();
        }
    }

}
