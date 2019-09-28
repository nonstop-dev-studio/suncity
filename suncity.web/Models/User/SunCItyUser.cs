using System;

namespace Suncity.Web.Models.User
{
    /// <summary>
    /// Sun city user
    /// </summary>
    public class SunCityUser : BaseUserModel
    {
        public string UserName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime Registered { get; set; }
        public DateTime LastLogon { get; set; }
    }
}
