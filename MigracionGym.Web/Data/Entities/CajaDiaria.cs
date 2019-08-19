namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;
    using System;

    public class CajaDiaria : IEntity
    {

        public int id { get; set; }
        public DateTime fecha { get; set; }
        public int categoria { get; set; }
        public string concepto { get; set; }
        public FormaPago formaPago { get; set; }
        public float debe { get; set; }
        public decimal haber { get; set; }
        public decimal saldo { get; set; }
    }
}
