using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using company_portal_server.Models;
using company_portal_server.Services;
using company_portal_server.Updates;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace company_portal_server.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class EmployeesController : ControllerBase
    {
        private readonly IEmployees _service;
        public EmployeesController(IEmployees service)
        {
            _service = service;
        }
        [Route("~/api/GetAllEmployees")]
        [HttpGet]
        public ActionResult<List<Employee>> GetAll()
        {
            return _service.GetAll();
        }

        [Route("~/api/GetEmployee/{id}")]

        [HttpGet("{id}")]
        public Employee GetById(int id)
        {
            return _service.GetById(id);
        }

        [Route("~/api/UpdateEmployee")]
        [HttpPut("{id}")]
        public Employee Update(int id, [FromBody] UpdateEmployee request)
        {
            return _service.Update(id, request);
        }

        [Route("~/api/AddEmployee")]
        [HttpPost]
        public Employee Insert(AddEmployee request)
        {
            return _service.Insert(request);
        }

    }
}
