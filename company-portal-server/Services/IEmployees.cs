using company_portal_server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace company_portal_server.Services
{
    public interface IEmployees
    {
        List<Employee> GetAll();
    }
}
