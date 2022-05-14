using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SampleKO.Business.Abstract;
using SampleKO.Model;

namespace SampleKO.API.Controllers
{
    [Route("api/[controller]/[Action]")]
    [ApiController]
    [Authorize]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            ResponseModel model = new ResponseModel();
            var result = _productService.GetAll();
            if (result.IsSuccess)
            {
                model.Data = result.Data;
                model.Message = result.Message;
                model.Status = result.Status();
                return Ok(model);
            }
            model.Message = result.Message;
            model.Status = result.Status();
            return BadRequest(model);
        }
    }
}
