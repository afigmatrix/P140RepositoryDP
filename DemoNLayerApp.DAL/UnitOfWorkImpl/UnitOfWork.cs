using DemoNLayerApp.DAL.Context;
using DemoNLayerApp.Domain.Repository;
using DemoNLayerApp.Domain.UnitOfWorkInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNLayerApp.DAL.UnitOfWorkImpl
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DemoNLayerAppDbContext context;

        public IProductRepository ProductRepository { get; private set; }

        public UnitOfWork(DemoNLayerAppDbContext context, IProductRepository productRepository)
        {
            this.context = context;
            ProductRepository = productRepository;
        }

        public async Task<int> Commit()
        {
            return await context.SaveChangesAsync();
        }
    }
}
