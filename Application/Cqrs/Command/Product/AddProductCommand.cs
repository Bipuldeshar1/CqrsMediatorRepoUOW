using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Cqrs.Command.Product
{
    public class AddProductCommand:IRequest
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public float Price { get; protected set; }

        public AddProductCommand(string name, string description,float price)
        {
            Name = name;
            Description = description;
            price = Price;
        }
    }
}
