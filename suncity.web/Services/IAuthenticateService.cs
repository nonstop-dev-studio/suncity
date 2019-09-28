using suncity.web.Models;

namespace suncity.web.Services
{
    public interface IAuthenticateService
    {
        bool IsAuthenticated(TokenRequest request, out string token);
    }
}
