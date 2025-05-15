namespace api.Services
{
    public interface IUserContext
    {
        bool IsAuthorized();
        int UserId { get; }
    }
}
