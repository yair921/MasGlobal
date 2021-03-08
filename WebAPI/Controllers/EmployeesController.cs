using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business;
using DataAccess.Models;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]/{id}")]
    public class EmployeesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<Employees> Get(string id)
        {
            var dto = new Business.DTO();
            return dto.GetEmployees(id);
        }
    }
}
