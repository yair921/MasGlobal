using DataAccess.Models;

namespace Business.Lib
{
    public class Salary
    {
        /// <summary>
        /// Method to calculate annual salary.
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        public static double CalculateSalary(EmployeesModel employee)
        {
            switch (employee.contractTypeName)
            {
                case "HourlySalaryEmployee":
                    return 120 * employee.hourlySalary * 12;
                case "MonthlySalaryEmployee":
                    return employee.monthlySalary * 12;
                default:
                    return 0;
            }
        }
    }
}
