namespace MigracionGym.Web.Data
{
using Microsoft.AspNetCore.Identity;
using Entities;
using System.Threading.Tasks;

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
