using DemoNLayerApp.BLL.Model.DTO;
using DemoNLayerApp.BLL.Service.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Threading.Tasks;

namespace DemoNLayerApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;
        private readonly IConfiguration configuration;

        public AuthController(IAuthService authService,IConfiguration configuration)
        {
            this.authService = authService;
            this.configuration = configuration;
        }
        [HttpPost]
        public async Task<UserLoginResponse> Login(UserLoginRequest login)
        {
            return await authService.Login(login, configuration);
        }
    }
}
