namespace MigracionGym.Web.Data.Entities
{

    using MigracionGym.Data.Entities;

    public class Domicilios : IEntity
    {
        public int Id { get; set; }
        public string Calle { get; set; }
        public string Nro { get; set; }
        public string Piso { get; set; }
        public string Dpto { get; set; }
        public string Barrio { get; set; }
        public string CodigoPostal { get; set; }
        public Localidades localidad { get; set; }
    }

}
