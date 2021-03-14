using System;
using System.Collections.Generic;

#nullable disable

namespace company_portal_server.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Projects = new HashSet<Project>();
        }

        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public int Creator { get; set; }
        public bool? Deleted { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? CustomerAddressId { get; set; }
        public int? CustomerStatusId { get; set; }

        public virtual CustomerAddress CustomerAddress { get; set; }
        public virtual CustomerStatus CustomerStatus { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
