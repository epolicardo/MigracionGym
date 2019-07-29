using MigracionGym.Data.Entities;
using System;

namespace MigracionGym.Web.Data.Entities
{
    public class Comprobantes : IEntity
    {
        public int Id { get; set ; }
        public DateTime fechaEmision { get; set; }
        public int nroComprobante { get; set; }
        public DetalleComprobantes detalleComprobantes { get; set; }
    }
}