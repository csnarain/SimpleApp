using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SimpleApp.Models;
using SimpleApp.ViewModels;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepository _employeeRepository;

        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public ViewResult Index()
        {
            var model = _employeeRepository.GetAllEmployees();
            return View(model);

            //return _employeeRepository.GetEmployee(3).Name;
        }
        public ViewResult Details()
        {
            var homeDetailsViewModel = new HomeDetailsViewModel()
            {
                Employee = _employeeRepository.GetEmployee(1),
                PageTitle = "Employee Details"
            };
            //var model = _employeeRepository.GetEmployee(3);
            //ViewBag.PageTitle = "Employee Details";
            return View(homeDetailsViewModel);
        }
    }
}
