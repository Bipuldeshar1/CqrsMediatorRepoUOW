using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.context
{
    public class AppDbCOntext:DbContext
    {
        public AppDbCOntext(DbContextOptions<AppDbCOntext>context):base(context) { }

        public DbSet<ProductModel> products { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new ProductEntityTypeConfiguration());
        }
    }
}
