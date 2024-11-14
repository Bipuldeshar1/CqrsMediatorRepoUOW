using Domain.Entities;
using Domain.Repository;
using Infrastructure.context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbCOntext _context;

        public ProductRepository(AppDbCOntext context)
        {
            this._context = context;
        }
        public async Task AddProduct(ProductModel product)
        {
          await _context.AddAsync(product);
        }

        public async Task DeleteProduct(ProductModel product)
        {
             _context.Remove(product);
        }

        public async Task<List<ProductModel>> getAllProducts()
        {
            return await _context.products.AsNoTracking().ToListAsync();
        }

        public async Task<ProductModel> getSingleProduct(int productId)
        {
           return await _context.products.AsNoTracking().FirstOrDefaultAsync(x=>x.Id== productId);   

        }

        public async Task UpdateProduct(ProductModel product)
        {
             _context.products.Update(product);
           
        }
    }
}
