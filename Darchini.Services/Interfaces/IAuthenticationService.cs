using Darchini.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eFoodOrder.Services.Interfaces
{
    public interface IAuthenticationService
    {
        public bool CreateUser(User user, string password);
        Task<bool> SignOut();
        User GetUser(string username);
        User Authenticateuser(string username , string Password);
    }
}
