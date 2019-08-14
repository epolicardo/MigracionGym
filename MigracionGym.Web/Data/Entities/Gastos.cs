namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data.Entities;
    using System;

    public class Gastos : IEntity
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Concepto { get; set; }
        public float Importe { get; set; }
        public int Tipo { get; set; }
    }
}
