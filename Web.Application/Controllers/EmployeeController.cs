using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Web.Application.Models;

namespace Web.Application.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ILogger<EmployeeController> _logger;
        private readonly IEmployeeRepository _employeeRepo;

        public EmployeeController(ILogger<EmployeeController> logger, IEmployeeRepository employeeRepo)
        {
            _logger = logger;
            _employeeRepo = employeeRepo;
        }

        public IActionResult Index()
        {
             var empViewModel = new EmployeeViewModel();
 
             var empDto = _employeeRepo.GetEmployeeDetails();

             var empDetails = empViewModel.GetEmployeeInformation(empDto);

            return View(empDetails);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
