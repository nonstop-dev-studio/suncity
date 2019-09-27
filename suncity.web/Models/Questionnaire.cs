using suncity.web.Models;
using suncity.web.Models.User;
using System;
using System.Collections.Generic;

namespace Suncity.Web.Models
{
    public class Questionnaire
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }

        public Address AddressResidence { get; set; }
        public Address AddressRegistration { get; set; }
        public bool IsRussianCitizenship { get; set; }
        public Contacts Contacts { get; set; }
        public List<Education> Education { get; set; }
    }
}