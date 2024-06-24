using DemoNLayerApp.BLL.Model.JWTDto;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNLayerApp.BLL.Service.Interface
{
    public interface ITokenService
    {
        Task<GenerateTokenResponse> GenerateToken(GenerateTokenRequest model, IConfiguration configuration);
    }
}
