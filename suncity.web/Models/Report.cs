using System;
//using suncity.web.Models.User;

namespace Suncity.Web.Models
{
    public class Report
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public string Child { get; set; }
        public string Mentor { get; set; }
        public string Status { get; set; }
        public string Duration { get; set; }
        public string WhatDidYouPlanToDoAtTheMeeting { get; set; }
        public string WhatDidYouEndUpDoing { get; set; }
        public string AssessTheMoodOfTheChildBeforeAndAfterTheMeeting { get; set; }
        public string TargetForNextMeeting { get; set; }
        public string DescribeYourMoodAfterTheMeeting  { get; set; }
        public string AdditionalComment { get; set; }
        public string Questions { get; set; }
    }
}