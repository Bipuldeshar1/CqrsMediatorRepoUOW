using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product
    {
        public int Id { get; protected set; }
        public Guid ProductGuid { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public float Price { get; protected set; }
        public bool IsDeleted {  get; protected set; }=false;
        protected Product(string name, string description, float price)
        {
            ProductGuid=Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
        }
       
        public virtual void Update(string name, string description,float price)
        {
            Name = name;
            Description = description;
            Price = price;
        }
        public virtual void Delete() { 
           IsDeleted = true;
        }
    }


}
