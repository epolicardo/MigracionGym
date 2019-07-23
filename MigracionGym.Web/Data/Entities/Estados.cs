namespace MigracionGym.Web.Data.Entities
{
using MigracionGym.Data.Entities;

    public class Estados : IEntity
    {
        public int Id { get; set; }
        public string Estado { get; set; }
    }
}
