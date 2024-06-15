using DemoNLayerApp.Domain.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNLayerApp.Domain.Repository
{
    public interface IProductRepository: IGenericRepository<Product>
    {
    }
}
