using Microsoft.AspNetCore.Identity;
using WashingCar_SantiagoVarela_.DAL.Entities;
using WashingCar_SantiagoVarela_.Models;

namespace WashingCar_SantiagoVarela_.Helpers
{
    public interface IUserHelper
    {
        Task<User> GetUserAsync(string email);

        Task<IdentityResult> AddUserAsync(User user, string password);

       // Task<User> AddUserAsync(AddUserViewModel addUserViewModel);

        Task CheckRoleAsync(string roleName);

        Task AddUserToRoleAsync(User user, string roleName);

        Task<bool> IsUserInRoleAsync(User user, string roleName);

        Task<SignInResult> LoginAsync(LoginViewModel loginViewModel);

        Task LogoutAsync();
    }
    }
