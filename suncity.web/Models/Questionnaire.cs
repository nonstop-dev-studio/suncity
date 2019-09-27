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
        public string Hobbies { get; set; }

        public Employment Employment { get; set; }
        public MaritalStatus MaritalStatus { get; set; }

        public bool AgreedToShareMedia { get; set; }
        public bool AgreedToMakeReports { get; set; }
        public string ProgrammInformationSource { get; set; }
        public bool ConsentProcessingPersonalData { get; set; }
        public bool AgreedWithLiabilities { get; set; }

    }
}