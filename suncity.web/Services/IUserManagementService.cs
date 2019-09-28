
namespace suncity.web.Services
{
    public interface IUserManagementService
    {
        bool IsValidUser(string username, string password);
    }
}
