namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;
    using System;

    public class Cheques : IEntity
    {
        public int id { get; set; }
        public Clientes cliente { get; set; }
        public string banco { get; set; }
        public string plaza { get; set; }
        public DateTime fechaCobro { get; set; }
        public decimal importe { get; set; }
    }
}
