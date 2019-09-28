using System;

namespace suncity.web.Models.User
{
    public class Employment
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyPhoneNumber { get; set; }
        public string Position { get; set; }
        public string Responsibilities { get; set; }
        public string WorkSchedule { get; set; }
    }
}
