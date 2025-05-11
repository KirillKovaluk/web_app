using api.Models;

namespace api.Services
{
    public class UserView
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        
        public string? Token { get; set; }
    }

    public static class UserViewExtension
    {
        public static UserView ToView(this User user, string? token = null)
        {
            var userView = new UserView
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                Token = token
            };

            return userView;
        }
    }
}
