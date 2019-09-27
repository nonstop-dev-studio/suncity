namespace suncity.web.Models.User
{
    public class Education
    {
        public EducationLevel EducationLevel { get; set; }
        public string EducationalInstitution { get; set; }
    }

    public enum EducationLevel
    {
        NA = 0,
        HighSchool = 1,
        Сollege = 2,
        BachelorDegree = 3,
        MasterDegree = 4
    }
}
