using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WashingCar_SantiagoVarela_.DAL;
using WashingCar_SantiagoVarela_.DAL.Entities;
using WashingCar_SantiagoVarela_.Helpers;

namespace WashingCar_SantiagoVarela_.Services
{
    public class UserHelper : IUserHelper
    {
        private readonly DatabaseContext _context;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        
        public UserHelper(DatabaseContext context, 
            UserManager<User> userManager, 
            RoleManager<IdentityRole> roleManager, 
            SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        
        }

        public async Task<IdentityResult> AddUserAsync(User user, string password)
        {
            return await _userManager.CreateAsync(user,password);
        }

        public async Task AddUserToRoleAsync(User user, string roleName)
        {
            await _userManager.AddToRoleAsync(user, roleName);
        }

        public async Task CheckRoleAsync(string roleName)
        {
            bool roleExist = await _roleManager.RoleExistsAsync(roleName);                           

            if (!roleExist) await _roleManager.CreateAsync(new IdentityRole { Name = roleName });
        }

        public async Task<User> GetUserAsync(string email)
        {
            return await _context.Users
                .FirstOrDefaultAsync(user => user.Email == email);
            
        }   

        public async Task<bool> IsUserInRoleAsync(User user, string roleName)
        {
            return await _userManager.IsInRoleAsync(user, roleName);
        }

       public Task LogoutAsync()
        {
            throw new NotImplementedException();
        } 
    }
}
