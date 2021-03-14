using System;
using System.Collections.Generic;

#nullable disable

namespace company_portal_server.Models
{
    public partial class Team
    {
        public Team()
        {
            Members = new HashSet<Member>();
            Projects = new HashSet<Project>();
        }

        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public int Creator { get; set; }
        public bool? Deleted { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
