using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json;
using DataAccess.Lib;

namespace DataAccess
{
    public class EmployeesService<T1> : IService<T1>
    {
        /// <summary>
        /// Method that call employee api.
        /// </summary>
        /// <returns>Type of list received</returns>
        public List<T1> Get()
        {
            HttpResponseMessage request =
              Http.HttpGetRequest("http://masglobaltestapi.azurewebsites.net", "/api/Employees");
            if (request.IsSuccessStatusCode)
            {
                string resultString = request.Content.ReadAsStringAsync().Result;
                List<T1> result = JsonConvert.DeserializeObject<List<T1>>(resultString);
                return result;
            }
            return null;
        }
    }
}
