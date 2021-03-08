using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Business;
using Business.Models;
using DataAccess.Models;

namespace Frontend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : Controller
    {
        private readonly EmployeesLogic _dto;

        public EmployeesController()
        {
            _dto = new EmployeesLogic();
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IEnumerable<GenericModel> Get()
        {
            return _dto.Get().ToArray();
        }

        [HttpGet("{id}")]
        public IEnumerable<GenericModel> Get(string id)
        {
            return _dto.Get(id).ToArray();
        }
    }
}
