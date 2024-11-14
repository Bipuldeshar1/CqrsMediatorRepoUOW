using Application.Cqrs.Command.Product;
using Application.Cqrs.Query.Product;
using Domain.Entities;
using Domain.Repository;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {

            this._mediator = mediator;
        }

        [HttpGet]
        [Route("getAll")]
        public async Task<IActionResult> GetAllProduct()
        {
            try
            {
                var query = new GetAllProductQuery();
                var result = await _mediator.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
        [HttpGet]
        [Route("getSingleProduct/{productId}")]
        public async Task<IActionResult> GetSingleProduct(int productId)
        {
            try
            {
                var query = new GetProductByIdQuery(productId);
                var result = await _mediator.Send(query);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }


        [HttpPost]
        [Route("add")]
        public async Task<IActionResult> AddProduct(ProductModel product)
        {
            try
            {
                var query = new AddProductCommand(product.Name, product.Description, product.Price);
                var result = await _mediator.Send(query);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        [HttpPatch]
        [Route("update")]
        public async Task<IActionResult> Updateproduct(ProductModel product)
        {
            try
            {
                var query = new UpdateProductCommand(product.Id, product.ProductGuid, product.Name, product.Description, product.Price, product.IsDeleted);
                var result = await _mediator.Send(query);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        [HttpDelete]
        [Route("delete/{productId}")]
        public async Task<IActionResult> DeleteProduct(int productId)
        {
            try
            {
                var query = new DeleteProductCommand(productId);
                var result = await _mediator.Send(query);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
