using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DemoNLayerApp.BLL.Model;
using DemoNLayerApp.BLL.Model.DTO;
using DemoNLayerApp.BLL.Service.Interface;
using Microsoft.AspNetCore.Authorization;
using System.Linq;
using System.Security.Claims;

namespace DemoNLayerApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }
        [HttpPost]
        public async  Task<IActionResult> Create(ProductAddDto product )
        {
            await productService.AddProduct( product );
            return NoContent();
        }

        [HttpGet]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> GetAll()
        {
            var userName = User.FindFirstValue(ClaimTypes.Role);
            var responseData =await productService.GetProducts();
            return Ok(responseData);
        }
    }
}
