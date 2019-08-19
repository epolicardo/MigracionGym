namespace MigracionGym.Web.Data.Entities
{
    using Microsoft.AspNetCore.Identity;

    public class Usuarios : IdentityUser
    {
        public string nombre { get; set; }
        public string apellido { get; set; }

    }
}
