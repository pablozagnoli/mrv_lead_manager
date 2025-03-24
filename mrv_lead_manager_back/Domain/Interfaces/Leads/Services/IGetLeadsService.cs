﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.Leads.Services
{
    public interface IGetLeadsService
    {
        IEnumerable<LeadsEntity> getLeads();
        IEnumerable<LeadsEntity> GetInvited();
        IEnumerable<LeadsEntity> GetAccepted();
    }
}
