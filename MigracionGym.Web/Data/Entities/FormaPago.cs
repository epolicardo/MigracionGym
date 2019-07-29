using MigracionGym.Data.Entities;

namespace MigracionGym.Web.Data.Entities
{
    public class FormaPago : IEntity
    {
        public int Id { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }
    }
}