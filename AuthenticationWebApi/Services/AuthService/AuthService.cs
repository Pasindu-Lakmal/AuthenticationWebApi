using AuthenticationWebApi.Models.Dtos;

namespace AuthenticationWebApi.Services.AuthService
{
    public class AuthService : IAuthService
    {
        public async Task<User> RegisterUser(UserDto requests)
        {
            var user = new User { Username = requests.Username };
            return user;
        }
    }
}
