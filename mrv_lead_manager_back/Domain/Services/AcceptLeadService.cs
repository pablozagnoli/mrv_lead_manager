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
    public class AcceptLeadService : IAcceptLeadService
    {

        private ILeadsRepository _LeadsRepository;
        private IMailService _IMailService;

        public AcceptLeadService(ILeadsRepository LeadsRepository, IMailService mailService)
        {
            _LeadsRepository = LeadsRepository;
            _IMailService = mailService;
        }

        public int AcceptLead(LeadsEntity lead)
        {
            if (lead.Price > 500)
            {
                lead.Price = lead.Price - (lead.Price / 10);
            }

            _IMailService.SendMailLeadAccept();

            var result = _LeadsRepository.UpdateLead(lead);
            return result;
        }
    }
}
