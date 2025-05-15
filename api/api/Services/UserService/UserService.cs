using api.DataContext;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Services
{
    public class UserService : IUserService
    {
        private readonly IErrorService _errorService;
        private readonly Context _context;
        private readonly IJWTService _jWTService;
        private readonly IUserContext _userContext;

        public UserService(
            IErrorService errorService,
            Context context,
            IJWTService jWTService,
            IUserContext userContext
            ) 
        {
            _errorService = errorService;
            _context = context;
            _jWTService = jWTService;
            _userContext = userContext;
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

            var userExist = await _context.Users
                .AsNoTracking()
                .AnyAsync(x => x.Name == userCreateInput.Name);

            if (userExist) 
            {
                _errorService.Add(ErrorCode.USER_NAME_ALREADY_EXISTS);
                return;
            }

            var userEmailExist = await _context.Users
                .AsNoTracking()
                .AnyAsync(x => x.Email == userCreateInput.Email);

            if (userEmailExist)
            {
                _errorService.Add(ErrorCode.USER_EMAIL_ALREADY_EXISTS);
                return;
            }

            var user = new User
            {
                Name = userCreateInput.Name,
                Email = userCreateInput.Email,
                Password = _jWTService.CreateHash(userCreateInput.Password),
            };

            _context.Users.Add(user);

            await _context.SaveChangesAsync();
        }

        public async Task<UserView> LoginUserAsync(UserLoginInput userLoginInput)
        {
            if (string.IsNullOrEmpty(userLoginInput.Name)
                || string.IsNullOrEmpty(userLoginInput.Password))
            {
                _errorService.Add(ErrorCode.MODEL_IS_INVALID);
                return null;
            }

            var userPasswordHashed = _jWTService.CreateHash(userLoginInput.Password);

            var user = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Name == userLoginInput.Name && x.Password == userPasswordHashed);

            if (user == null) 
            {
                _errorService.Add(ErrorCode.USER_NOT_FOUND);
                return null;
            }

            var token = GetToken(user);

            return user.ToView(token);
        }

        public async Task<UserView> GetUserAsync()
        {
            var user = await _context.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == _userContext.UserId);

            if (user == null)
            {
                _errorService.Add(ErrorCode.USER_NOT_FOUND);
                return null;
            }

            return user.ToView();
        }

        #region Private Methods

        private string GetToken(User user)
        {
            return _jWTService.GetToken(user);
        }

        #endregion
    }
}
