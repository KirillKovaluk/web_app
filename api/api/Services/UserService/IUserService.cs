namespace api.Services
{
    public interface IUserService
    {
        Task CreateUserAsync(UserCreateInput userCreateInput);
        Task<UserView> LoginUserAsync(UserLoginInput userLoginInput);
    }
}
