using suncity.web.Models;
//using suncity.web.Models.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Suncity.Web.Models
{
    public class Questionnaire
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
        public string BirthDate { get; set; }
        public string City { get; set; }
        public string IsRussianCitizenship { get; set; }
        public string AddressResidence { get; set; }
        [ForeignKey("AddressRegistrationId")]
        public string AddressRegistration { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

    }
}