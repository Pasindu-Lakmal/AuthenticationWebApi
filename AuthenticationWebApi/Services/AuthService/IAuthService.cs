using AuthenticationWebApi.Models.Dtos;

namespace AuthenticationWebApi.Services.AuthService
{
    public interface IAuthService
    {
        Task<User> RegisterUser(UserDto requests);
    }
}
