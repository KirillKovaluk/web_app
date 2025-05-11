namespace api.Services
{
    public class UserService : IUserService
    {
        private readonly IErrorService _errorService;

        public UserService(
            IErrorService errorService
            ) 
        {
            _errorService = errorService;
        }

        public async Task CreateUserAsync(UserCreateInput userCreateInput)
        {
            if (string.IsNullOrEmpty(userCreateInput.Name)
                || string.IsNullOrEmpty(userCreateInput.Email)
                || string.IsNullOrEmpty(userCreateInput.Password))
            {
                _errorService.Add(ErrorCode.MODEL_IS_INVALID);
                return;
            }


            return;
        }
    }
}
