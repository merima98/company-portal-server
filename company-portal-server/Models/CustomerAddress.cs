using System;
using System.Collections.Generic;

#nullable disable

namespace company_portal_server.Models
{
    public partial class CustomerAddress
    {
        public CustomerAddress()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public DateTime? Created { get; set; }
        public int Creator { get; set; }
        public bool? Deleted { get; set; }
        public string Road { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
