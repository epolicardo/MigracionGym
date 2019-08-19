namespace MigracionGym.Web.Data.Entities
{
using MigracionGym.Data;

    public class Domicilios : IEntity
    {
        public int id { get; set; }
        public string calle { get; set; }
        public string nro { get; set; }
        public string piso { get; set; }
        public string dpto { get; set; }
        public string barrio { get; set; }
        public string codigoPostal { get; set; }
        public Localidades localidad { get; set; }
    }

}
