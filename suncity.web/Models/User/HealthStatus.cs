namespace Suncity.Web.Models.User
{
    public class HealthStatus
    {
        public HealthMark Mark { get; set; }
        public string Notes { get; set; }
    }

    public enum HealthMark
    {
        NA = 0,
        Excellent = 1,
        Good = 2,
        Average = 3,
        Bad = 4
    }
}
