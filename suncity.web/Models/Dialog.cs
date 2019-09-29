using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace suncity.web.Models
{
    public class Dialog
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string firstHuman { get; set; }
        public string SecondHuman { get; set; }
    }
}
