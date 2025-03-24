using Dapper;
using Domain.Entities;
using Domain.Interfaces.Leads.Repository;
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
            return new List<LeadsEntity> {
                new LeadsEntity
                {
                    category = "teste 1",
                     status = 1,
                    name = "dasdsa",
                    created = DateTime.Now,
                    SubBurd = "dsadsa",
                    Id =1,
                    description = "teste",
                    Price = 10

                },
                new LeadsEntity
                {
                    category = "teste 2",
                    status = 1,
                    name = "dsadsa",
                    created = DateTime.Now,
                    SubBurd = "dsadsa",
                    Id =1,
                    description = "teste",
                    Price = 10
                }
            };
            var sql = "SELECT * FROM leads";
            var result = this._connection.Query<LeadsEntity>(sql);
            return result;
        }


        public IEnumerable<LeadsEntity> GetInvited()
        {
            return new List<LeadsEntity> {
                new LeadsEntity
                {
                    category = "teste 1",
                     status = 1,
                    name = "dasdsa",
                    created = DateTime.Now,
                    SubBurd = "dsadsa",
                    Id =1,
                    description = "teste",
                    Price = 10

                },
                new LeadsEntity
                {
                    category = "teste 2",
                    status = 1,
                    name = "dsadsa",
                    created = DateTime.Now,
                    SubBurd = "dsadsa",
                    Id =1,
                    description = "teste",
                    Price = 10
                }
            };
            var sql = "SELECT * FROM leads";
            var result = this._connection.Query<LeadsEntity>(sql);
            return result;
        }


        public IEnumerable<LeadsEntity> GetAccepted()
        {
            return new List<LeadsEntity> {
                new LeadsEntity
                {
                    category = "teste 1",
                     status = 1,
                    name = "dasdsa",
                    created = DateTime.Now,
                    SubBurd = "dsadsa",
                    Id =1,
                    description = "teste",
                    Price = 10

                },
                new LeadsEntity
                {
                    category = "teste 2",
                    status = 1,
                    name = "dsadsa",
                    created = DateTime.Now,
                    SubBurd = "dsadsa",
                    Id =1,
                    description = "teste",
                    Price = 10
                }
            };
            var sql = "SELECT * FROM leads";
            var result = this._connection.Query<LeadsEntity>(sql);
            return result;
        }

        public int UpdateLead(LeadsEntity lead)
        {
            var sql = $"UPDATE leads SET status = {lead.status} where id = {lead.Id};";
            var result = this._connection.Execute(sql);
            return result;
        }
    }
}
