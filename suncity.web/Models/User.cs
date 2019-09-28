using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace suncity.web.Models
{
    public class User : IdentityUser
    {
        public string AuthToken { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
