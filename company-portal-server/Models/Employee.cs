using System;
using System.Collections.Generic;

#nullable disable

namespace company_portal_server.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Days = new HashSet<Day>();
            Members = new HashSet<Member>();
        }

        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public int Creator { get; set; }
        public bool? Deleted { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Image { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public int? EmployeeStatusId { get; set; }
        public int? EmployeePositionId { get; set; }

        public virtual EmployeePosition EmployeePosition { get; set; }
        public virtual EmployeeStatus EmployeeStatus { get; set; }
        public virtual ICollection<Day> Days { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
}
