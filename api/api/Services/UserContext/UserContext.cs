namespace api.Services
{
    public class UserContext : IUserContext
    {
        private readonly IHttpContextAccessor _contextAccessor;

        public UserContext(IHttpContextAccessor contextAccessor)
        {
            _contextAccessor = contextAccessor;
        }
        public bool IsAuthorized()
        {
            var user = _contextAccessor.HttpContext.User;
            return user != null;
        }

        public int UserId
        {
            get
            {
                var user = _contextAccessor.HttpContext.User;
                if (user != null && !string.IsNullOrEmpty(user.Identity.Name))
                {
                    return int.Parse(user.Identity.Name);
                }
                return 0;
            }
        }

    }
}
