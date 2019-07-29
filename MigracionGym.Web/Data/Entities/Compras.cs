namespace MigracionGym.Web.Data.Entities
{

    using MigracionGym.Data.Entities;
    
    public class Compras : IEntity
    {
        public int Id { get; set; }
        public string Fecha { get; set; }
        public string CantItem { get; set; }
        public FormaPago formaPago { get; set; }
        public Comprobantes comprobantes { get; set; }
        public string ImporteTotal { get; set; }
        public Proveedores Proveedores { get; set; }
    }
}
