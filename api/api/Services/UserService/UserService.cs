using api.DataContext;
using Microsoft.EntityFrameworkCore;
using api.Models;

namespace api.Services
{
    public class UserService : IUserService
    {
        private readonly IErrorService _errorService;
        private readonly Context _context;
        public UserService(
            IErrorService errorService,
            Context context) 
        {
            _errorService = errorService;
            _context = context;
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
                Password = userCreateInput.Password,
            };

            _context.Users.Add(user);

            await _context.SaveChangesAsync();
        }
    }
}
