using suncity.web.Models.User;

namespace suncity.web.Models
{
    public class MentorProfile
    {
        SCUser Mentor { get; set; }

        public string Religion { get; set; }

        public HealthStatus HealthStatus { get; set; }
    }
}
