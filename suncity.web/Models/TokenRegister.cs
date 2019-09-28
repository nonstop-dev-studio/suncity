using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace suncity.web.Models
{
    public class TokenRegister
    {
        [Required]
        [JsonProperty("username")]
        public string Username { get; set; }


        [Required]
        [JsonProperty("password")]
        public string Password { get; set; }

        [Required]
        [JsonProperty("confirm-password")]
        public string ConfirmPassword { get; set; }
    }
}