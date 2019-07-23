namespace MigracionGym.Web.Helpers
{
    using Microsoft.AspNetCore.Identity;
    using MigracionGym.Web.Data.Entities;
    using System.Threading.Tasks;

    public interface IUserHelper
    {
        Task<Usuarios> GetUserByEmailAsync(string email);
        Task<IdentityResult> AddUserAsync(Usuarios usuarios, string password);
    }
}
