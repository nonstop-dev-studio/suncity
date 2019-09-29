using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace suncity.web.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Key { get; set; }
        public string Msg { get; set; }
    }
}
