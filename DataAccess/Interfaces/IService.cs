using System.Collections.Generic;

namespace DataAccess
{
    public interface IService<T1>
    {
        List<T1> Get();
    }
}
