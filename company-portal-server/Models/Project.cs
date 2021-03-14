using System;
using System.Collections.Generic;

#nullable disable

namespace company_portal_server.Models
{
    public partial class Project
    {
        public Project()
        {
            Assignements = new HashSet<Assignement>();
        }

        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public int Creator { get; set; }
        public bool? Deleted { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? TeamId { get; set; }
        public int? CustomerId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? ProjectStatusId { get; set; }
        public int? ProjectPricingId { get; set; }
        public decimal Amount { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ProjectPricing ProjectPricing { get; set; }
        public virtual ProjectStatus ProjectStatus { get; set; }
        public virtual Team Team { get; set; }
        public virtual ICollection<Assignement> Assignements { get; set; }
    }
}
