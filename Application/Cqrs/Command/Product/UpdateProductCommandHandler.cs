using Domain.Entities;
using Domain.Repository;
using Domain.UnitOfWork;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cqrs.Command.Product
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand>
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public UpdateProductCommandHandler(IProductRepository productRepository,IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var product = new ProductModel(request.Name, request.Description,request.Price);
                await _productRepository.UpdateProduct(product);
                await _unitOfWork.saveChangesAsync();
                return Unit.Value;
            }
            catch (Exception ex)
            {
                throw ;
            }
        }
    }
}
