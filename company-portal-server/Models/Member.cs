using System;
using System.Collections.Generic;

#nullable disable

namespace company_portal_server.Models
{
    public partial class Member
    {
        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public int Creator { get; set; }
        public bool? Deleted { get; set; }
        public int? TeamId { get; set; }
        public int? EmployeeId { get; set; }
        public int? RoleId { get; set; }
        public int? MemberStatusId { get; set; }
        public decimal HoursWeekly { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual MemberStatus MemberStatus { get; set; }
        public virtual Role Role { get; set; }
        public virtual Team Team { get; set; }
    }
}
