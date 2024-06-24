using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoNLayerApp.BLL.Model.DTO
{
    public class UserLoginResponse
    {
        public string Token { get; set; }
        public DateTime ExpireDate { get; set; }
    }
}
