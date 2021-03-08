using DataAccess;
using DataAccess.Models;
using Business.Models;
using Business.DTO;
using Business.Lib;
using System.Collections.Generic;
using System.Linq;
using System;

namespace Business
{
    public class EmployeesLogic
    {
        #region PUBLIC METHODS

        /// <summary>
        /// Method to get all employees.
        /// </summary>
        /// <returns>List of employees</returns>
        public List<GenericModel> Get()
        {
            try
            {
                return CallService();
            }
            catch (Exception e)
            {
                ErrorsLogs.WriteError(e.Message);
                return new List<GenericModel>();
            }
        }

        /// <summary>
        /// Method to get an specific employee.
        /// </summary>
        /// <param name="id">Employee id</param>
        /// <returns>List with the employee information</returns>
        public List<GenericModel> Get(string id)
        {
            List<GenericModel> employees;
            try
            {
                employees = CallService();
                return employees.Where(item => item.id == Int16.Parse(id)).ToList();
            }
            catch (Exception e)
            {
                ErrorsLogs.WriteError(e.Message);
                return new List<GenericModel>();
            }
        }

        #endregion

        #region PRIVATE METHODS

        /// <summary>
        /// Generic method to invoke a get service.
        /// </summary>
        /// <returns>List employees</returns>
        private List<GenericModel> CallService()
        {
            EmployeesService<EmployeesModel> services = new EmployeesService<EmployeesModel>();
            List<EmployeesModel> employees = services.Get();
            return EmployeesDTO.EmployeesData(employees);
        }
        #endregion
    }
}
