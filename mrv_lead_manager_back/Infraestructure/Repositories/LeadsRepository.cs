using Dapper;
using Domain.Entities;
using Domain.Interfaces.Leads;
using MyApp.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repositories
{
    public class LeadsRepository : ILeadsRepository
    {

        private readonly IDbConnection _connection;

        public LeadsRepository(IDbConnection connection)
        {
            _connection = connection;
        }

        public IEnumerable<LeadsEntity> getLeads()
        {
            var sql = "SELECT * FROM leads";
            var result = this._connection.Query<LeadsEntity>(sql);
            return result;
        }

        public int updateLead(LeadsEntity lead)
        {
            var sql = $"UPDATE leads SET accept = 1 where id = {lead.Id};";
            var result = this._connection.Execute(sql);
            return result;
        }
    }
}
