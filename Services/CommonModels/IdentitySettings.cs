using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.CommonModels
{
    public class IdentitySettings
    {
        public string JWTKey { get; set; }
        public string JWTIssuer { get; set; }
        public string JWTAudience { get; set; }

    }
}
