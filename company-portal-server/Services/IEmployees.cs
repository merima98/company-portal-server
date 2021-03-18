using company_portal_server.Models;
using company_portal_server.Updates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace company_portal_server.Services
{
    public interface IEmployees
    {
        List<Employee> GetAll();
        Employee GetById(int employeeId);
        Employee Update(int id, UpdateEmployee request);
        Employee Insert(AddEmployee request);
    }
}
