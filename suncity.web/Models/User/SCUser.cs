using System.Collections.Generic;

namespace suncity.web.Models.User
{
    public class SCUser : BaseUserModel
    {
        public Address AddressResidence { get; set; }
        public Address AddressRegistration { get; set; }
        public bool IsRussianCitizenship { get; set; }
        public Contacts Contacts { get; set; }
        public List<Education> Education { get; set; }
    }
}
