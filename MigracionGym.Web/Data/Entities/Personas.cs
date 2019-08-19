namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;
    using System;

    public class Personas : IEntity
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string dni { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public Localidades lugarNacimiento { get; set; }

    }
}
