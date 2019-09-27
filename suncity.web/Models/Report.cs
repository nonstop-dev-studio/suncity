using System;
using suncity.web.Models.User;
namespace Suncity.Web.Models
{
    public class Report
    {
        public long Id { get; set; }
        public DateTime date { get; set; }
        public SCUser child { get; set; }
        public SCUser mentor { get; set; }
        public bool status { get; set; }
        public int duration { get; set; }

        public string whatDidYouPlanToDoAtTheMeeting { get; set; }
        public string whatDidYouEndUpDoing { get; set; }
        public string assessTheMoodOfTheChildBeforeAndAfterTheMeeting { get; set; }
        public string targetForNextMeeting { get; set; }
        public string describeYourMoodAfterTheMeeting { get; set; }
        public string additionalComment { get; set; }
        public string questions { get; set; }
    }
}