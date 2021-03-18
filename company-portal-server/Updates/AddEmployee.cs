using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace company_portal_server.Updates
{
    public class AddEmployee
    { 
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
    }
}
