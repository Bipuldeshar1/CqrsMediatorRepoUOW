using Domain.Entities;
using Domain.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> GetAllProduct()
        {
            var result = await _productRepository.getAllProducts();
            return Ok(result);    
        }
        [HttpGet]
        [Route("getSingleProduct")]
        public async Task<IActionResult> GetSingleProduct()
        {
            var result = await _productRepository.getAllProducts();
            return Ok(result);
        }

        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddProduct(Product product)
        {
             await _productRepository.AddProduct(product);
            return Ok();
        }

        [HttpPatch]
        [Route("update")]
        public async Task<IActionResult> Updateproduct(Product product)
        {
            await _productRepository.UpdateProduct(product);
            return Ok();
        }

        [HttpDelete]
        [Route("delete/{productGuid}")]
        public async Task<IActionResult> DeleteProduct([FromQuery]Guid productGuid)
        {
           var product= await _productRepository.getSingleProduct(productGuid);
            await _productRepository.DeleteProduct(product);
            return Ok();
        }
    }
}
