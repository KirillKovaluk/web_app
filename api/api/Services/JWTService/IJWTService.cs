using api.Models;

namespace api.Services
{
    public interface IJWTService
    {
        string CreateHash(string inputString);
        string GetToken(User user);
    }
}
