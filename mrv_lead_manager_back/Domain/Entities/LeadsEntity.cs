using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class LeadsEntity
    {
        public int status { get; set; }
        public string name { get; set; }
        public DateTime created { get; set; }
        public string SubBurd { get; set; }
        public string category { get; set; }
        public int Id { get; set; }
        public string description { get; set; }
        public decimal Price { get; set; }
    }
}
