using DemoNLayerApp.BLL.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNLayerApp.BLL.Service.Interface
{
    public interface IProductService
    {
        Task<List<ProductGetAllDto>> GetProducts();
        Task AddProduct(ProductAddDto product);
    }
}
