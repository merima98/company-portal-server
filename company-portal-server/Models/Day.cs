using System;
using System.Collections.Generic;

#nullable disable

namespace company_portal_server.Models
{
    public partial class Day
    {
        public Day()
        {
            Assignements = new HashSet<Assignement>();
        }

        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public int Creator { get; set; }
        public bool? Deleted { get; set; }
        public DateTime? Date { get; set; }
        public int? EmployeeId { get; set; }
        public int? DayTypeId { get; set; }

        public virtual DayType DayType { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Assignement> Assignements { get; set; }
    }
}
