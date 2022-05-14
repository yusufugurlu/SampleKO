using SampleKO.Model;
using SampleKO.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleKO.Business.Abstract
{
    public interface IAccessService
    {
        ServiceResult Login(LoginUserViewModel loginUserView);

    }
}
