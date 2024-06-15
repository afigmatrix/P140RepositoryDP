using DemoNLayerApp.DAL.Context;
using DemoNLayerApp.Domain.Entity;
using DemoNLayerApp.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNLayerApp.DAL.Repository
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DemoNLayerAppDbContext context) : base(context)
        { }
    }
}
