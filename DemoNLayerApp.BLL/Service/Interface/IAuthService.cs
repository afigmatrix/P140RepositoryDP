using DemoNLayerApp.BLL.Model.DTO;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNLayerApp.BLL.Service.Interface
{
    public interface IAuthService
    {
        Task<UserLoginResponse> Login(UserLoginRequest login,IConfiguration configuration);
    }
}
