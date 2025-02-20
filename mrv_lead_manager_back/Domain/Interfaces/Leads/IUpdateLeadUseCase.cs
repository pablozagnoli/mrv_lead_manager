using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Leads
{
    public interface IUpdateLeadUseCase
    {
        int UpdateLead(LeadsEntity lead);
    }
}
