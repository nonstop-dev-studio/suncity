using System.ComponentModel.DataAnnotations;

namespace suncity.web.Models.User
{
    public class MaritalStatus
    {
        [Key]
        public string State { get; set; }
    }
}
