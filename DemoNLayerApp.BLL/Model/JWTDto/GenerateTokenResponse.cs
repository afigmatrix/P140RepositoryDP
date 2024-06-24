using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNLayerApp.BLL.Model.JWTDto
{
    public class GenerateTokenResponse
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
