namespace Suncity.Web.Models.User
{
    public class Education
    {
        public int Id { get; set; }
        public EducationLevel EducationLevel { get; set; }
        public string EducationalInstitution { get; set; }
    }

    public enum EducationLevel
    {
        NA = 0,
        HighSchool = 1,
        Сollege = 2,
        BachelorDegree = 3,
        Specialist = 4,
        MasterDegree = 5
    }
}
