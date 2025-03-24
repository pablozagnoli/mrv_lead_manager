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

        public async Task<IEnumerable<LeadsEntity>> GetLeadsAsync()
        {
            return await _context.Leads.ToListAsync();
        }

        public async Task<IEnumerable<LeadsEntity>> GetInvitedAsync()
        {
            return await _context.Leads.Where(l => l.status == 1).ToListAsync();
        }

        public async Task<IEnumerable<LeadsEntity>> GetAcceptedAsync()
        {
            return await _context.Leads.Where(l => l.status == 2).ToListAsync();
        }

        public async Task<int> UpdateLeadAsync(LeadsEntity lead)
        {
            _context.Leads.Update(lead);
            return await _context.SaveChangesAsync();
        }
    }

}
