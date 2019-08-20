namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;
    using System;

    public class Gastos : IEntity
    {
        public int id { get; set; }
        public DateTime fecha { get; set; }
        public string concepto { get; set; }
        public decimal importe { get; set; }
        public int tipo { get; set; }
        public Usuarios usuario { get; set; }
    }
}
