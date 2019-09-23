namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;
    using System;

    public class Proveedores : IEntity
    {
        public int id { get; set; }
        public string RazonSocial { get; set; }
        public DateTime FechaAlta { get; set; }

    }
}