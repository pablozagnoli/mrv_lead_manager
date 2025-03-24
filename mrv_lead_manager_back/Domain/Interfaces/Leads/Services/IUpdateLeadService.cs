using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Leads.Services
{
    public interface IUpdateLeadService
    {
        public int UpdateLead(LeadsEntity lead);
    }
}
