using System.Collections.Generic;

namespace DataAccess
{
    public class Service<T1> : IService<T1>
    {
        IService<T1> _service;
        public Service(IService<T1> service)
        {
            _service = service;
        }

        /// <summary>
        /// Generic method invoke method Get.
        /// </summary>
        /// <returns>Type of list received</returns>
        public List<T1> Get()
        {
            return _service.Get();
        }
    }
}
