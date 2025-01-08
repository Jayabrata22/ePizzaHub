using eFoodOrder.Services.Interfaces;
using Darchini.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFoodOrder.Services.Implementation
{
    public class AuthenticationService : IAuthenticationService
    {

        protected SignInManager<User> _signManager;
        protected UserManager<User> _userManager;
        protected RoleManager<Role> _RoleManager;

        public AuthenticationService(SignInManager<User> signInManager,
            UserManager<User> userManager, RoleManager<Role> roleManager )
        {
            _RoleManager = roleManager;
            _signManager = signInManager;
            _userManager = userManager;
        }
        public User Authenticateuser(string username, string Password)
        {
            var result = _signManager.PasswordSignInAsync(username, Password,false,
                lockoutOnFailure:false).Result;
            if (result.Succeeded)
            {
                var users = _userManager.FindByNameAsync(username).Result;
                var Role = _userManager.GetRolesAsync(users).Result;
                users.Roles = Role.ToArray();

                return users;
            }
            return null;
        }

        public bool CreateUser(User user, string password)
        {
            var result = _userManager.CreateAsync(user, password).Result;
            if(result.Succeeded)
            {
                string role = "Admin";
                var res = _userManager.AddToRoleAsync(user, role).Result;
                if (res.Succeeded)
                {
                    return true;
                }
            }
            return false;
        }

        public User GetUser(string username)
        {
            return _userManager.FindByNameAsync(username).Result;
        }

        public async Task<bool> SignOut()
        {
            await _signManager.SignOutAsync();
            return true;
        }
    }
}
