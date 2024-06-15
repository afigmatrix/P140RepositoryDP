using DemoNLayerApp.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNLayerApp.Domain.UnitOfWorkInterface
{
    public interface IUnitOfWork
    {
        IProductRepository ProductRepository { get; }
        Task<int> Commit();
    }
}
