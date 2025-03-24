using Domain.Entities;
using Domain.Interfaces.Leads.Repository;
using Microsoft.EntityFrameworkCore;
using MyApp.Infrastructure.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class LeadsRepository : ILeadsRepository
    {
        private readonly AppDbContext _context;

        public LeadsRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<LeadsEntity> getLeads()
        {
            return _context.Leads.ToList();
        }

        public IEnumerable<LeadsEntity> GetInvited()
        {
            return _context.Leads.Where(l => l.status == 1).ToList();
        }

        public IEnumerable<LeadsEntity> GetAccepted()
        {
            return _context.Leads.Where(l => l.status == 2).ToList();
        }

        public int UpdateLead(LeadsEntity lead)
        {
            _context.Leads.Update(lead);
            return _context.SaveChanges();
        }
    }
}
