using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Repository
{
    public interface IProductRepository
    {
        Task<List<ProductModel>> getAllProducts();
        Task<ProductModel> getSingleProduct(int productId);
        Task AddProduct(ProductModel product);
        Task UpdateProduct(ProductModel product);
        Task DeleteProduct(ProductModel product);
    }
}
