using SampleKO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.Business.Abstract
{
    public interface IUnitOfWorks
    {
        IGenericRepository<T> GetGenericRepository<T>() where T : class, new();

        ServiceResult SaveChanges();
    }
}
