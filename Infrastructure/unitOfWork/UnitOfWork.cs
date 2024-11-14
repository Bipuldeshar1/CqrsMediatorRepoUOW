using Domain.Repository;
using Domain.UnitOfWork;
using Infrastructure.context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.unitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        public IProductRepository ProductRepository { get; }
        private readonly AppDbCOntext _context;
        public UnitOfWork(IProductRepository productRepository,AppDbCOntext context)
        {
            ProductRepository = productRepository;
            _context = context; 
        }
        public async Task<int> saveChangesAsync()
        {
          return await _context.SaveChangesAsync();
        }
    }
}
