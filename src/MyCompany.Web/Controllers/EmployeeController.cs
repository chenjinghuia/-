using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Employee;
using MyCompany.Web.Model;

namespace MyCompany.Web.Controllers
{
    public class EmployeeController : MyCompanyControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<ActionResult> Index(GetAllEmployeeInput input)
        {
            var output = await _employeeService.GetAll(input);
            var model = new IndexViewModel(output.Items);
            return View(model);
        }
    }
}