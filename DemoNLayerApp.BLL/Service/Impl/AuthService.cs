using DemoNLayerApp.BLL.Model.DTO;
using DemoNLayerApp.BLL.Model.JWTDto;
using DemoNLayerApp.BLL.Service.Interface;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNLayerApp.BLL.Service.Impl
{
    public class AuthService : IAuthService
    {
        private readonly ITokenService tokenService;

        public AuthService(ITokenService tokenService)
        {
            this.tokenService = tokenService;
        }
        public async Task<UserLoginResponse> Login(UserLoginRequest request,IConfiguration configuration)
        {

            UserLoginResponse response = new();

            if (string.IsNullOrEmpty(request.Email) || string.IsNullOrEmpty(request.Password))
            {
                throw new ArgumentNullException(nameof(request));
            }


            if (request.Email == "Matrix@m.az" && request.Password == "Matrix12345")
            {
                var generatedTokenInformation = await tokenService.GenerateToken(new GenerateTokenRequest { Email = request.Email }, configuration);

                response.Token = generatedTokenInformation.Token;
                response.ExpireDate = generatedTokenInformation.ExpireDate;
            }

            return response;
        }
    }
}
