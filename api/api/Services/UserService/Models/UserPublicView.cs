using api.Models;

namespace api.Services
{
    public class UserPublicView
    {
        public int Id { get; set; }
        public string? Name { get; set; }

    }

    public static class UserPublicViewExtension
    {
        public static UserPublicView ToPublicView(this User user)
        {
            var userPublicView = new UserPublicView
            {
                Id = user.Id,
                Name = user.Name
            };

            return userPublicView;
        }
    }
}
