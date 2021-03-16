using AutoMapper;
using company_portal_server.Models;
using company_portal_server.Updates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace company_portal_server.Mappers
{
    public class Mepper : Profile
    {
        public Mepper()
        { 
            CreateMap<UpdateEmployee, Employee>();
        }
    }
}
