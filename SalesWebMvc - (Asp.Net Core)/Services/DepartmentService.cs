using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Data;
using SalesWebMvc____Asp.Net_Core_.Models;

namespace SalesWebMvc.Services
{
    public class DepartmentService 
    {
        private readonly SalesWebMvcContext _context; //readonly não permitir alteração

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Department> FindAll() {
            return _context.Department.OrderBy(x => x.Name).ToList(); 

    }
}
