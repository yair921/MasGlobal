using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new DTO();
            var employees = service.GetEmployees();
            Console.WriteLine(employees);
        }
    }
}
