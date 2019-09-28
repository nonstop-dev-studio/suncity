using System;
using System.ComponentModel.DataAnnotations;

namespace Suncity.Web.Models
{
    public class ChatConnection
    {
        public string ChatConnectionId { get; set; }

        [Key]
        public string UserId { get; set; }
        public DateTime Connected { get; set; }
    }
}
