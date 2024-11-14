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
    public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand>
    {
        private readonly IProductRepository _productRepository;
        private readonly IUnitOfWork _unitOfWork;


        public DeleteProductCommandHandler(IProductRepository productRepository,IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }
        public async Task<Unit> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var product = await _productRepository.getSingleProduct(request.Id);

                await _productRepository.DeleteProduct(product);
                await _unitOfWork.saveChangesAsync();
                return Unit.Value;
            }
            catch (Exception ex) {
                throw ;
            }
            
        }
    }
}
