using System;
using System.Collections.Generic;

#nullable disable

namespace company_portal_server.Models
{
    public partial class MemberStatus
    {
        public MemberStatus()
        {
            Members = new HashSet<Member>();
        }

        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public int Creator { get; set; }
        public bool? Deleted { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Member> Members { get; set; }
    }
}
