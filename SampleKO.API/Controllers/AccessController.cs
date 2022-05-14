using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleKO.Business.Abstract;
using SampleKO.Model.ViewModel;
using System.Net;

namespace SampleKO.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    public class AccessController : ControllerBase
    {
        private readonly IAccessService _accessService;
        public AccessController(IAccessService accessService)
        {
            _accessService = accessService;
        }

        [HttpPost]
        public IActionResult Login(LoginUserViewModel model)
        {
            var result=_accessService.Login(model);
            if (result.Status() == (int)HttpStatusCode.OK)
            {
                return Ok(result);
            }
            return Ok(result);
        }
    }
}
