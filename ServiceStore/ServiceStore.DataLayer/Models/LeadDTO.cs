using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceStore.DataLayer
{
    public class LeadDTO
    {
        public int Id { get; set; }
        public string LeadId { get; set; }
        public DateOnly SubStartDate { get; set; }
        public DateOnly SubEndDate { get; set; }
        public int ServiceId { get; set; }
    }
}
