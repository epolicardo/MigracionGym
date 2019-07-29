namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data.Entities;
    using System;

    public class CajaDiaria : IEntity
    {

        public int Id { get; set; }
        public DateTime fecha { get; set; }
        public int categoria { get; set; }
        public string concepto { get; set; }
        public FormaPago formaPago { get; set; }
        public float debe { get; set; }
        public float haber { get; set; }
        public float saldo { get; set; }
    }
}
