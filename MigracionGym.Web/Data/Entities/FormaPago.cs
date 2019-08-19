namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;

    public class FormaPago : IEntity
    {
        public int id { get; set; }
        public int codigo { get; set; }
        public string nombre { get; set; }
    }
}