using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cqrs.Command.Product
{
    public class UpdateProductCommand:IRequest
    {
        public int Id { get; protected set; }
        public Guid ProductGuid { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public float Price { get; protected set; }
        public bool IsDeleted { get; protected set; } = false;

        public UpdateProductCommand(int id,Guid productGuid,string name,string description,float price,bool isDeleted)
        {
            Id= id;
            ProductGuid = productGuid;
            Name = name;
            Description = description;
            Price = price;
            IsDeleted = isDeleted;
        }
    }

}
