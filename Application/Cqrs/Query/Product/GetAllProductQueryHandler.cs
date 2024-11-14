using Domain.Entities;
using Domain.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cqrs.Query.Product
{
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<ProductModel>>
    {
        private readonly IProductRepository _productRepository;

        public GetAllProductQueryHandler(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        public async Task<List<ProductModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            var products = await _productRepository.getAllProducts();
           
            return products;
        }
    }
}
