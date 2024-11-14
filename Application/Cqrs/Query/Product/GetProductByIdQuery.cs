using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cqrs.Query.Product
{
    public class GetProductByIdQuery:IRequest<ProductModel>
    {
        public int ProductId {  get; set; }
        public GetProductByIdQuery(int productId)
        {
            ProductId = productId;
        }
    }
}
