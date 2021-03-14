using System;
using System.Collections.Generic;

#nullable disable

namespace company_portal_server.Models
{
    public partial class Assignement
    {
        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public int Creator { get; set; }
        public bool? Deleted { get; set; }
        public string Description { get; set; }
        public decimal Hours { get; set; }
        public int? DayId { get; set; }
        public int? ProjectId { get; set; }

        public virtual Day Day { get; set; }
        public virtual Project Project { get; set; }
    }
}
