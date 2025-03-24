using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Leads.UseCases
{
    public interface IAcceptLeadUseCase
    {
        int AcceptLead(LeadsEntity lead);
    }
}
