using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        [Route("getAll")]
        public IActionResult GetAllProduct()
        {
            return Ok();
        }

        [HttpPost]
        [Route("add")]
        public IActionResult AddProduct()
        {
            return Ok();
        }

        [HttpPatch]
        [Route("update")]
        public IActionResult Updateproduct()
        {
            return Ok();
        }

        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult DeleteProduct([FromQuery]int id)
        {
            return Ok();
        }
    }
}
