namespace MigracionGym.Web.Data.Entities
{
    using MigracionGym.Data;
    using System;

    public class Comprobantes : IEntity
    {
        public int id { get; set; }
        public DateTime fechaEmision { get; set; }
        public int nroComprobante { get; set; }
        public DetalleComprobantes detalleComprobantes { get; set; }
    }
}