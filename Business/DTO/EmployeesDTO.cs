using System.Collections.Generic;
using System.Linq;
using DataAccess.Models;
using Business.Models;
using Business.Lib;

namespace Business.DTO
{
    public class EmployeesDTO : Salary
    {
        /// <summary>
        /// Return employees data with new model and annual salary.
        /// </summary>
        /// <param name="employees">List employee object</param>
        /// <returns></returns>
        public static List<GenericModel> EmployeesData(List<EmployeesModel> employees)
        {
            return employees.Select(e => new GenericModel()
            {
                id = e.id,
                name = e.name,
                contractTypeName = e.contractTypeName,
                roleName = e.roleName,
                annualSalary = CalculateSalary(e)
            }).ToList();
        }
    }
}
