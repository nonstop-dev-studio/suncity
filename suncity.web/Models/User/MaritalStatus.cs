using System.ComponentModel.DataAnnotations;

namespace Suncity.Web.Models.User
{
    public class MaritalStatus
    {
        [Key]
        public string State { get; set; }
    }
}
