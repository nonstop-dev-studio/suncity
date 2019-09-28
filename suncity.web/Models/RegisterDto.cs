using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace suncity.web.Models
{
    public enum Role
    {
        Mentor = 1,
        Curator = 2,
        Psychologist = 3,
        MainCurator = 4,
        MainMentor = 5,
        User = 6,
        Admin = 7
    }
    public class RegisterDto
    {
        [Required]
        public string FirstName { get; set; }
        
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public Role Role { get; set; }
        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
    }
}
