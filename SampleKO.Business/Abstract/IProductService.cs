using SampleKO.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.Business.Abstract
{
    public interface IProductService
    {
        ServiceResult GetAll();
    }
}
