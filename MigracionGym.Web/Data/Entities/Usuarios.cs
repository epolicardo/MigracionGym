namespace MigracionGym.Web.Data.Entities
{
using Microsoft.AspNetCore.Identity;

    public class Usuarios : IdentityUser
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
    }
}
