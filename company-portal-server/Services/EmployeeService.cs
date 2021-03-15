using company_portal_server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace company_portal_server.Services
{
    public class EmployeeService : IEmployees
    {
        protected readonly company_portalContext _company_PortalContext;

        public EmployeeService(company_portalContext company_PortalContext)
        {
            _company_PortalContext = company_PortalContext;
        } 

        List<Employee> IEmployees.GetAll()
        {
            var list = _company_PortalContext.Employees.ToList();
            return list;
        }
    }
}
