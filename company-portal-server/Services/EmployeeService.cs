using AutoMapper;
using company_portal_server.Models;
using company_portal_server.Updates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace company_portal_server.Services
{
    public class EmployeeService : IEmployees
    {


        protected readonly IMapper _mapper;
        protected readonly company_portalContext _company_PortalContext;

        public EmployeeService(company_portalContext company_PortalContext, IMapper mapper)
        {
            _company_PortalContext = company_PortalContext;
            _mapper = mapper;
        }

        public Employee GetById(int employeeId)
        {
            var employee = _company_PortalContext.Employees.Where(x => x.Id == employeeId).First();
            return employee;
        }

        public Employee Insert(AddEmployee request)
        {
            var entity = _mapper.Map<Employee>(request);
            _company_PortalContext.Set<Employee>().Add(entity);
            _company_PortalContext.SaveChanges();
            return _mapper.Map<Employee>(entity);
        }

        public Employee Update(int id, UpdateEmployee request)
        {

            var entity = _company_PortalContext.Employees.Where(x=>x.Email==request.Email).FirstOrDefault();
            _company_PortalContext.Set<Employee>().Attach(entity);
            _company_PortalContext.Set<Employee>().Update(entity);

            _mapper.Map(request, entity);
            _company_PortalContext.SaveChanges();

            return entity;
        }

        List<Employee> IEmployees.GetAll()
        {
            var list = _company_PortalContext.Employees.ToList();
            return list;
        }
    }
}
