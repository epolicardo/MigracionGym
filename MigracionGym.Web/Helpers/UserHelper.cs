using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MigracionGym.Web.Data.Entities;

namespace MigracionGym.Web.Helpers
{
    public class UserHelper : IUserHelper
    {
        private readonly UserManager<Usuarios> userManager;

        public UserHelper(UserManager<Usuarios> userManager)
        {
            this.userManager = userManager;
        }

        public async Task<IdentityResult> AddUserAsync(Usuarios usuarios, string password)
        {
            return await this.userManager.CreateAsync(usuarios, password);
        }

        public async Task<Usuarios> GetUserByEmailAsync(string email)
        {
            return await this.userManager.FindByEmailAsync(email);
            //var user = await this.userManager.FindByEmailAsync(email);
            //return user;
        }
    }
}
