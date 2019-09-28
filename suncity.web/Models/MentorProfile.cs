using Suncity.Web.Models.User;

namespace Suncity.Web.Models
{
    public class MentorProfile
    {
        SunCityUser Mentor { get; set; }

        public string Religion { get; set; }

        public HealthStatus HealthStatus { get; set; }
    }
}
