using DemoNLayerApp.BLL.Model.DTO;
using DemoNLayerApp.BLL.Service.Interface;
using DemoNLayerApp.Domain.Entity;
using DemoNLayerApp.Domain.UnitOfWorkInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNLayerApp.BLL.Service.Impl
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task AddProduct(ProductAddDto product)
        {
            if (string.IsNullOrEmpty(product.Name))
            {
                throw new KeyNotFoundException("Name is not valid");
            }

            var productEntity = new Product { Name = product.Name };

            await unitOfWork.ProductRepository.Add(productEntity);
            await unitOfWork.Commit();
        }

        public async Task<List<ProductGetAllDto>> GetProducts()
        {
            var productEntities = await unitOfWork.ProductRepository.GetAll();
            var response = productEntities.Select(m => new ProductGetAllDto
            {
                Name = m.Name
            }).ToList();

            return response;
        }
    }
}
