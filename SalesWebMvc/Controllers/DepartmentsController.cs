using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> List = new List<Department>();
            List.Add(new Department { Id = 1, Name = "Eletronics"});
            List.Add(new Department { Id = 2, Name = "Fashion" });

            return View(List);
        }
    }
}
